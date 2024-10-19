using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 velocity;
    public float jump;
    public Rigidbody myRb;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocity.x = Input.GetAxis("Horizontal");
        velocity.y = myRb.velocity.y;
        velocity.z = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Jump")){
            velocity.y = 5;
        }
        myRb.velocity = velocity;
    }
}
