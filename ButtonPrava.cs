using UnityEngine;
using System.Collections;

public class ButtonPrava : MonoBehaviour {

    private bool left;
    private bool right;
    private Animator animator;
    bool go;
    bool usl;
    bool vib = true;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
	

    public void button () 
    {
        if (vib == true)
        {
            go = false;
            usl = true;
            vib = false;
        }
        else
        {
            if (vib == false)
            {
                go = true;
                usl = false;
                vib = true;
            }
        }
        
        
    
    }

        
        void Update()
    {
        if (go == false && usl == true)
        {
            right = false;
            left = true;
            
        }
        else
        {
            if (go == true && usl == false)
            {
                left = false;
                right = true;
                
            }

            
        }

        animator.SetBool("Left", left);
        animator.SetBool("Right", right);
    }


   

}
