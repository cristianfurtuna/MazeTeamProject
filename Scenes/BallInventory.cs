using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInventory : MonoBehaviour
{
    [SerializeField]
    public static int NumberOfKeys;

    public void KeyCollected()
    {
        NumberOfKeys++;
    }
}