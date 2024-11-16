using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 torque;
    private Vector3 input;
    private Movement myMovement;

    void Start()
    {
        myMovement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        torque.y = Input.GetAxis("Mouse X");
        input.x = Input.GetAxis("Horizontal");
        input.z = Input.GetAxis("Vertical");
        myMovement.direction = transform.rotation * input;
        transform.Rotate (torque);
        if (Input.GetButtonDown("Jump"))
        {
            myMovement.Jump();
        }

        
    }
}
