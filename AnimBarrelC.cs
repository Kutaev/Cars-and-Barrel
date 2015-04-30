using UnityEngine;
using System.Collections;

public class AnimBarrelC : MonoBehaviour
{

    
    public static int live;
    Animator animator;
    bool now3 = false;
    void Start()
    {
        live = 0;
        now3 = false;
        animator = GetComponent<Animator>();
    }


    void Update()
    {

        if (live == 3)
            now3= true;
        animator.SetBool("Now3", now3);


    }
}

