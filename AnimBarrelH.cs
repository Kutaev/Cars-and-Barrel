using UnityEngine;
using System.Collections;

public class AnimBarrelH : MonoBehaviour {

    public static int live;
    Animator animator;
    bool now8 = false;
    void Start()
    {
        live = 0;
        now8 = false;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (live == 8)
            now8 = true;
        animator.SetBool("Now8", now8);
    }
}
