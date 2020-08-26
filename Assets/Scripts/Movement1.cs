using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Movement1 : MonoBehaviour
{

    private Rigidbody rb;
    private float playerInput;
    [SerializeField] private float movementSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }

    private void FixedUpdate()
    {
        Move(new Vector3(0, 0, playerInput*-1));
    }

    private void Move(Vector3 direction)
    {
        rb.AddForce(direction * movementSpeed);
    }

    private void PlayerInput()
    {
        playerInput = Input.GetAxis("Horizontal");
    }
}
