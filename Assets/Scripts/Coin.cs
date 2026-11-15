using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Coin : MonoBehaviour
{
    private int coinCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            coinCount++;
            Debug.Log("Coins collected: " + coinCount);
            Destroy(other.gameObject);
        }
    }
}
