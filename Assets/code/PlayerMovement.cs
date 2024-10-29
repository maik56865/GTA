using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 velocity;
    public float speedJump;
    public float speed;
    private Rigidbody myRb;
    private Vector3 torque;
    
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        torque.y = Input.GetAxis("Mouse X") * Time.deltaTime * 100 ;
        velocity.x = Input.GetAxis("Horizontal") * speed ;
        velocity.y = myRb.velocity.y;
        velocity.z = Input.GetAxis("Vertical") * speed ;
        if (Input.GetButtonDown("Jump")){
            velocity.y = speedJump;
        }
        myRb.velocity =  transform.rotation * velocity  ;
        

        transform.Rotate(torque);
    }
}
