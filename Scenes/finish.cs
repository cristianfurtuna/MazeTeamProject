using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class finish : MonoBehaviour
{
    

    [SerializeField]
    public GameObject won = null;


    private void OnTriggerEnter(Collider Other) {

        if (BallInventory.NumberOfKeys == 3)
        {
            GameObject.Find("keytext").GetComponent<Text>().enabled = true;
            BallInventory.NumberOfKeys = 0;
            //Instantiate(won, new Vector3(0, 0, 0), Quaternion.identity) ;
        }
            

    }

}
