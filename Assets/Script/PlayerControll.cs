using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float speed = 5.0f;
    // public Camera playerCamera;
    private CharacterController controller;
    private Vector3 moveDirections = Vector3.zero;
    // private float rotationX = 0;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        float curSpeedX = speed * Input.GetAxis("Vertical");
        float curSpeedY = speed * Input.GetAxis("Horizontal");

        moveDirections = (forward * curSpeedX) + (right * curSpeedY);
        controller.Move(moveDirections * Time.deltaTime);


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("Kena");
        }
    }
}
