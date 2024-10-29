using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleAnimation : MonoBehaviour
{
    private Animator animator;
    private Rigidbody myRb; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myRb.velocity.y > 0.1f ||myRb.velocity.y < -0.1f) 
        {
            animator.SetBool("OnAir", true);

        }
        else
        {
            animator.SetBool("OnAir", false);
        }
        if (myRb.velocity.magnitude > 0.1f) 
        {
            animator.SetBool("Walk", true);
        }
        else { animator.SetBool("Walk", false); }
    }

}
