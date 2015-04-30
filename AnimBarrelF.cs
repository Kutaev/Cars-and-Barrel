using UnityEngine;
using System.Collections;

public class AnimBarrelF : MonoBehaviour {

    public static int live;
    Animator animator;
    bool now6 = false;
    void Start()
    {
        live = 0;
        now6 = false;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (live == 6)
            now6 = true;
        animator.SetBool("Now6", now6);
    }
}
