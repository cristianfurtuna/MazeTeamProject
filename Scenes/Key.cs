using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider Other)
    {
        BallInventory ballInventory = Other.GetComponent<BallInventory>();
        if (ballInventory != null)
        {
            ballInventory.KeyCollected();
            gameObject.SetActive(false);
        }
    }
}
