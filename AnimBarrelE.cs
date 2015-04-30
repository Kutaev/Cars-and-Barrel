using UnityEngine;
using System.Collections;

public class AnimBarrelE : MonoBehaviour {

    public static int live;
    Animator animator;
    bool now5 = false;
    void Start()
    {
        live = 0;
        now5 = false;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (live == 5)
            now5 = true;
        animator.SetBool("Now5", now5);
    }


}
