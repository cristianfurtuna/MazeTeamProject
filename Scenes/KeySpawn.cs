using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeySpawn : MonoBehaviour
{
    [SerializeField]
    private Transform key1 = null;

    [SerializeField]
    private Transform key2 = null;

    [SerializeField]
    private Transform key3 = null;

    public GameObject textkey;
    public float[] pozition;

    public GameObject finish;
    public GameObject door;

    // Update is called once per frame

    void Start()
    {
        Instantiate(key1, new Vector3(3.893458f, -0.4487362f, 0.5223546f), Quaternion.identity);
   
        Instantiate(key2, new Vector3(-4.993995f, -0.4487362f, 3.901298f), Quaternion.identity);

        Instantiate(key3, new Vector3(-4.917574f, -0.4487362f, -4.956982f), Quaternion.identity);
       

             
            
        

    }

    void update()
    {
        


        

    }
}