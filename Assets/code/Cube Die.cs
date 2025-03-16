using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDie : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
     
    }

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Haeth>().TakeDamage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
