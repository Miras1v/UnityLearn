using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController  : MonoBehaviour
{
    private Animator Anim;

    void Start()
    {
        Anim = this.gameObject.GetComponent<Animator>();
        
    }

    void Update()
    {
        float hor= Input.GetAxis("Horizontal");
        if (hor != 0)
        {
            Anim.SetBool("walk",true);
        }
        else 
        {
            Anim.SetBool("walk",false);
        }
    }
}
