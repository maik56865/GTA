using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haeth : MonoBehaviour
{
    public Animator animator;
    public float HP;

    // Start is called before the first frame update
    public void RIP()
    {
        animator.SetBool("Die", true);
    }
    void Start()

    {

    }

    public void TakeDamage()
    {
        HP -= 1;
        animator.SetTrigger("Damage");
        if (HP <= 0)
        {
            RIP();
        }


    }




    // Update is called once per frame
    void Update()
    {

    }
}
     

