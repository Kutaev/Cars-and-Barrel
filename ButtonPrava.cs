using UnityEngine;
using System.Collections;

public class ButtonPrava : MonoBehaviour {

    private bool left3;
    private bool right3;
    public static bool three = false;
    private bool left2;
    private bool right2;
    public static bool two = false;
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
            if (two == false && three == false)
            {
                right = false;
                left = true;
            }
            
            if (two == true)
            {
                right2 = false;
                left2 = true;
            }
            
            if (three == true)
            {
                right3 = false;
                left3= true;
            }

        }
        else
        {
            if (go == true && usl == false)
            {
                if (two == false && three == false)
                {
                    left = false;
                    right = true;
                }
                
                if (two == true)
                {
                    right2 = true;
                    left2 = false;
                }

                if (three == true)
                {
                    right3 = true;
                    left3 = false;
                }
                
            }

            
        }

        animator.SetBool("Left", left);
        animator.SetBool("Right", right);
        animator.SetBool("Left2", left2);
        animator.SetBool("Right2", right2);
        animator.SetBool("Left3", left3);
        animator.SetBool("Right3", right3);

    }


   

}
