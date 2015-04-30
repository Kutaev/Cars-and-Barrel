using UnityEngine;
using System.Collections;

public class AnimBarrelD : MonoBehaviour
{

    public static int live;
    Animator animator;
    bool now4 = false;
    void Start()
    {
        live = 0;
        now4 = false;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (live == 4)
            now4 = true;
        animator.SetBool("Now4", now4);
    }


}
