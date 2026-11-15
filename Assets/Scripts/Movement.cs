using System.Net.Sockets;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 groundBoxSize = new Vector3(1.4f, 0.4f, 1.4f);

    public float speed = 12f;
    public float gravity = -9.81f;
    public int Recoil = 25;
    public float drag = 5f;
    public Transform groundCheck;

    public Transform Camera;
    public float groundDistance = 0.4f;

    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckBox(groundCheck.position, groundBoxSize * 0.5f, groundCheck.rotation, groundMask, QueryTriggerInteraction.Ignore);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (Input.GetMouseButton(0) && isGrounded)
        {

            velocity = (-Camera.forward * Recoil);
            //velocity.z = (recoilAmount);
        }

        Vector3 move = transform.right * x + transform.forward * z;

       //controller.Move(move* speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        Vector3 horizontal = new Vector3(velocity.x, 0f, velocity.z);
        horizontal = Vector3.MoveTowards(horizontal, Vector3.zero, drag * Time.deltaTime);
        velocity.x = horizontal.x;
        velocity.z = horizontal.z;


        controller.Move((move*speed+velocity)*Time.deltaTime);
    }
}
