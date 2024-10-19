using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] public Transform target ;

    public void Update()
    {
        transform.rotation = target.rotation;
        transform.position = target.position;
    }
}
