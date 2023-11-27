using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keynr : MonoBehaviour
{

    public GameObject textkey;


    void update()
    {
        textkey.GetComponent<Text>().text = "Key ";

        if (BallInventory.NumberOfKeys == 3)
        {



        }


    }
}
