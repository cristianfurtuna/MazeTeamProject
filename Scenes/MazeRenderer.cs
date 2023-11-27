using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRenderer : MonoBehaviour
{

    [SerializeField]
    [Range(1, 50)]
    private int width = 10;

    [SerializeField]
    [Range(1, 50)]
    private int height = 10;

    [SerializeField]
    private float size = 1f;

    [SerializeField]
    private Transform wallPrefab = null;

    [SerializeField]
    private Transform floorPrefab = null;

    [SerializeField]
    private Transform doorPrefab = null;

    private int mazeEndX, mazeEndY;

    // Start is called before the first frame update
    void Start()
    {
        var maze = MazeGenerator.Generate(width, height);

        mazeEndX = Random.Range(0, width);
        mazeEndY = Random.Range(0, 4);
        if (mazeEndY == 1)
            mazeEndY = height-1;
        else if (mazeEndY == 2)
        {
            var aux = mazeEndX;
            mazeEndX = 0;
            mazeEndY = aux;
        }
        else if (mazeEndY == 3)
        {
            var aux = mazeEndX;
            mazeEndX = width-1;
            mazeEndY = aux;
        }
        //Debug.Log(mazeEndX + "  " + mazeEndY);
            
        Draw(maze);
    }

    private void Draw(WallState[,] maze)
    {

        var floor = Instantiate(floorPrefab, transform);
        floor.position = new Vector3(-0.5f, -0.5f, -0.5f);
        floor.localScale = new Vector3(width, 0.1f, height);

        for (int i = 0; i < width; ++i)
        {
            for (int j = 0; j < height; ++j)
            {
                var cell = maze[i, j];
                var position = new Vector3(-width / 2 + i, 0, -height / 2 + j);
                var x = 0;

                if (i == mazeEndX && j == mazeEndY)
                {
                    if(i == 0)
                    {//left
                        var leftWall = Instantiate(doorPrefab, transform) as Transform;
                        leftWall.position = position + new Vector3(-size / 2, 0, 0);
                        leftWall.localScale = new Vector3(size, leftWall.localScale.y, leftWall.localScale.z);
                        leftWall.eulerAngles = new Vector3(0, 90, 0);
                        x = 1;
                    }
                    else if (i == width - 1)
                    {//right
                        var rightWall = Instantiate(doorPrefab, transform) as Transform;
                        rightWall.position = position + new Vector3(+size / 2, 0, 0);
                        rightWall.localScale = new Vector3(size, rightWall.localScale.y, rightWall.localScale.z);
                        rightWall.eulerAngles = new Vector3(0, 90, 0);
                        x = 2;
                    }
                    else if (j == 0)
                    {//top
                        var bottomWall = Instantiate(doorPrefab, transform) as Transform;
                        bottomWall.position = position + new Vector3(0, 0, -size / 2);
                        bottomWall.localScale = new Vector3(size, bottomWall.localScale.y, bottomWall.localScale.z);
                        x = 4;
                    }
                    else if (j == width - 1)
                    {//bot
                        var topWall = Instantiate(doorPrefab, transform) as Transform;
                        topWall.position = position + new Vector3(0, 0, size / 2);
                        topWall.localScale = new Vector3(size, topWall.localScale.y, topWall.localScale.z);
                        x = 3;
                    }
                }

                if (cell.HasFlag(WallState.UP) && x != 3)
                {
                    var topWall = Instantiate(wallPrefab, transform) as Transform;
                    topWall.position = position + new Vector3(0, 0, size / 2);
                    topWall.localScale = new Vector3(size, topWall.localScale.y, topWall.localScale.z);
                }

                if (cell.HasFlag(WallState.LEFT) && x != 1)
                {
                    var leftWall = Instantiate(wallPrefab, transform) as Transform;
                    leftWall.position = position + new Vector3(-size / 2, 0, 0);
                    leftWall.localScale = new Vector3(size, leftWall.localScale.y, leftWall.localScale.z);
                    leftWall.eulerAngles = new Vector3(0, 90, 0);
                }

                if (i == width - 1)
                {
                    if (cell.HasFlag(WallState.RIGHT) && x != 2)
                    {
                        var rightWall = Instantiate(wallPrefab, transform) as Transform;
                        rightWall.position = position + new Vector3(+size / 2, 0, 0);
                        rightWall.localScale = new Vector3(size, rightWall.localScale.y, rightWall.localScale.z);
                        rightWall.eulerAngles = new Vector3(0, 90, 0);
                    }
                }

                if (j == 0)
                {
                    if (cell.HasFlag(WallState.DOWN) && x != 4)
                    {
                        var bottomWall = Instantiate(wallPrefab, transform) as Transform;
                        bottomWall.position = position + new Vector3(0, 0, -size / 2);
                        bottomWall.localScale = new Vector3(size, bottomWall.localScale.y, bottomWall.localScale.z);
                    }
                }
                
            }

        }

    }

  


    // Update is called once per frame
    void Update()
    {
        
    }
}
