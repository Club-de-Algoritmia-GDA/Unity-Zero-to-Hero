using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class VerticalMove : MonoBehaviour
{
    private Rigidbody rb;
    private float direction;
    [SerializeField]private float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        userInput();
    }

    private void FixedUpdate()
    {
        Move(new UnityEngine.Vector3(direction, 0,0));
    }

    private void userInput()
    {
        direction = Input.GetAxis("Vertical");
    }

    private void Move(UnityEngine.Vector3 movement)
    {
        rb.AddForce(movement*speed*-1);
    }
}
