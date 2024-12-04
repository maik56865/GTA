using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPCFolower : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 myPos;
    public Vector3 targetPos;
    private Movement movement;
    

    void Start()
    {
        movement = GetComponent<Movement>();
        myPos = transform.position;
        targetPos = myPos;
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            targetPos = other.transform.position;
        }
    }
    void Update()
         
    {
        myPos = transform.position;
        Vector3 directionTotarget;
        directionTotarget = targetPos - myPos;
        directionTotarget.y = 0;
        float distanceTotarget;
        distanceTotarget = directionTotarget.magnitude;
        if (distanceTotarget > 1)
        {
            movement.direction = directionTotarget;
            transform.forward = directionTotarget;
        }
        
        
    }
}
