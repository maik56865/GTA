using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 velocity;
    public float speedJump=5;
    public float speed=5;
    private Rigidbody myRb;
    private Vector3 torque;
    bool isGround;
    public Vector3 direction;
    
    
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray();
        ray.origin = transform.position;
        ray.direction = transform.up * -1;
        isGround = Physics.Raycast(ray,0.5f);
        torque.y = Input.GetAxis("Mouse X") * Time.deltaTime * 100 ;
        velocity = direction.normalized * speed;
        velocity.y = myRb.velocity.y;
        myRb.velocity = velocity;
        



    }
     public void Jump()
    {
        if (isGround)
        {
            velocity.y = speedJump;
            myRb.velocity = velocity;
        }
    }
}
