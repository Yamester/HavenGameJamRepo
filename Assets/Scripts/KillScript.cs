using UnityEngine;
using UnityEngine.EventSystems;

public class KillScript : MonoBehaviour
{
    public Transform Player;
    public CharacterController controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Death"))
        {
            Debug.Log("You died idiot");
            controller.enabled = false;
            Player.position = new Vector3(0f, 1f, 0f);
            controller.enabled = true;
        }

    }
}
