using UnityEngine;
using System.Collections;

public class AnimBarrelA : MonoBehaviour {

   
    public static int live;
    Animator animator;
    bool now = false;

    void Start()
    {
        live = 0;
        now = false;
        animator = GetComponent<Animator>();
    }


     void Update()
    {

        if (live == 1)
        now = true;

        animator.SetBool("Now", now);

    }
     
}

