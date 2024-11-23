using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPCFolower : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 myPos;
    public GameObject target;
    private Movement movement;
    void Start()
    {
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionTotarget;
        myPos = transform.position;
        directionTotarget = target.transform.position - myPos;
        movement.direction = directionTotarget ;
        
    }
}
