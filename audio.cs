using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class audio : MonoBehaviour
{
    public GameObject volum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        volum.GetComponent<AudioSource>().volume = GameObject.Find("Volume Slider").GetComponent<Slider>().value;
    }
}
