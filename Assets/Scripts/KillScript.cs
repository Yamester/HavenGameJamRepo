using UnityEngine;
using UnityEngine.EventSystems;

public class KillScript : MonoBehaviour
{
    public Transform Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Death"))
        {
            Debug.Log("You died idiot");
            Player.localPosition = new Vector3(0f, 1f, 0f);

        }

    }
}
