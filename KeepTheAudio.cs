using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepTheAudio : MonoBehaviour
{
    void Awake()
    {

    
            DontDestroyOnLoad(transform.gameObject);

    }
}
