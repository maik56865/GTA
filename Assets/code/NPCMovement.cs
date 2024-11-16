using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPCMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private Vector3 velocity;
    public GameObject target;
    Vector3 myPos;
    Vector3 targetPos;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myPos = transform.position;
        targetPos = target.transform.position;
        velocity = targetPos - myPos;
        rb.velocity = velocity;
        
    }
}
