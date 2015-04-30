using UnityEngine;
using System.Collections;

public class AnimMenuCar : MonoBehaviour {
    
    bool forward = false;
    Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }
    public void goforward () 
    {
       forward = true;
       animator.SetBool("Forward", forward);
    }
	   

	
}
