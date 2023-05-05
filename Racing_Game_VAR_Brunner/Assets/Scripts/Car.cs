using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float acceleration = 1;
    public float steering = 1;
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        rigid.AddForce(transform.forward * verticalInput * acceleration * Time.deltaTime);      
        transform.Rotate(Vector3.up, horizontalInput * steering * Time.deltaTime);

        Vector3 velocity = rigid.velocity;
        velocity = transform.forward * velocity.magnitude;
        rigid.velocity = velocity;
    }
}
