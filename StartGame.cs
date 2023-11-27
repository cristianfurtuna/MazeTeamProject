using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Build number of scene to start when start button is pressed
    public int gameStartScene;
    
    public void PlayGame()
    {
        SceneManager.LoadScene(gameStartScene);
    }
}
