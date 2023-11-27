using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float MovementSpeed = 10f;
    private float xIn;
    private float yIn;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }


private void FixedUpdate()
{
    //Movement
    Move();
}

private void ProcessInputs()
{
    xIn = Input.GetAxis("Horizontal");
    yIn = Input.GetAxis("Vertical");
}

private void Move()
{
    rb.AddForce(new Vector3(xIn, 0f, yIn) * MovementSpeed);
}

}
