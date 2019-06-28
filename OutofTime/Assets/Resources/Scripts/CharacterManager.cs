using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterManager : MonoBehaviour
{

    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    public float mouseSpeed = 2.0f;

    private Vector3 moveDirection = Vector3.zero;

    private CursorLockMode lockMode;

    // Start is called before the first frame update
    void Start()
    {

        characterController = GetComponent<CharacterController>();

        //Cursor.visible = false;
        lockMode = CursorLockMode.Locked;
        Cursor.lockState = lockMode;

    }

    // Update is called once per frame
    void Update()
    {

        if (characterController.isGrounded) {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = this.transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump")) {

                moveDirection.y = jumpSpeed;

            }

        }

        moveDirection.y -= gravity * Time.deltaTime;

        characterController.Move(moveDirection * Time.deltaTime);

        float mouseH = mouseSpeed * Input.GetAxis("Mouse X");

        transform.Rotate(0, mouseH, 0);

    }
}
