using UnityEngine;
using System.Collections;

public class AnimBarrelG : MonoBehaviour {

    public static int live;
    Animator animator;
    bool now7 = false;
    void Start()
    {
        live = 0;
        now7 = false;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (live == 7)
            now7 = true;
        animator.SetBool("Now7", now7);
    }
}
