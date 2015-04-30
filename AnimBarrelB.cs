using UnityEngine;
using System.Collections;

public class AnimBarrelB : MonoBehaviour
{
    
    public static int live;
    Animator animator;
    bool now2 = false;
   
    void Start () 
    {
        live = 0;
        now2 = false;
        animator = GetComponent<Animator>();
	}
	

    void Update()
    {

        if(live == 2)
        now2 = true;
      
       
        animator.SetBool("Now2", now2);
       
    }

}

