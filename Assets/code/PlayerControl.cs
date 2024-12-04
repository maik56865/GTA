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
    public VariableJoystick joystick;

    void Start()
    {
        myMovement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        torque.y = Input.GetAxis("Mouse X");
        input.x = joystick.Horizontal;
        input.z = joystick.Vertical; 
        myMovement.direction = transform.rotation * input;
        transform.Rotate (torque);
        if (Input.GetButtonDown("Jump"))
        {
            myMovement.Jump();
        }

        
    }
}
