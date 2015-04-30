using UnityEngine;
using System.Collections;

public class LevelS : MonoBehaviour
{
    bool backl = true;
    bool nextl = false;
    Animator animator;
    public static int save;
    int dast;
    void Start()
    {
        animator = GetComponent<Animator>();
        dast = PlayerPrefs.GetInt("Cash", MonKey.Gold); 
        save = save + dast;
        PlayerPrefs.SetInt("Cash", 0);
        PlayerPrefs.SetInt("Save", save);
    }

    public void OneLevel()
    {

        PlayerPrefs.SetInt("Load", 1);
        Application.LoadLevel(4);
        
    }
    public void TwoLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 2)
        {
            PlayerPrefs.SetInt("Load", 2);
            Application.LoadLevel(4);
        }
        }
    public void ThreeLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 3)
        {
            PlayerPrefs.SetInt("Load", 3);
            Application.LoadLevel(4);
        }
    }
    public void FourLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 4)
        {
            PlayerPrefs.SetInt("Load", 4);
            Application.LoadLevel(4);
        }
    }

    public void FiveLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 5)
        {
            PlayerPrefs.SetInt("Load", 5);
            Application.LoadLevel(4);
        }
    }
    public void SixLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 6)
        {
            PlayerPrefs.SetInt("Load", 6);
            Application.LoadLevel(4);
        }
    }
    public void SevenLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 7)
        {
            PlayerPrefs.SetInt("Load", 7);
            Application.LoadLevel(4);
        }
    }
    public void EghtLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 8)
        {
            PlayerPrefs.SetInt("Load", 8);
            Application.LoadLevel(4);
        }
    }
    public void NineLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 9)
        {
            PlayerPrefs.SetInt("Load", 9);
            Application.LoadLevel(4);
        }
    }
    public void TenLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 10)
        {
            PlayerPrefs.SetInt("Load", 10);
            Application.LoadLevel(4);
        }
    }
    public void ElevenLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 11)
        {
            PlayerPrefs.SetInt("Load", 11);
            Application.LoadLevel(4);
        }
    }
    public void TwelveLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 12)
        {
            PlayerPrefs.SetInt("Load", 12);
            Application.LoadLevel(4);
        }
    }
    public void ThirteenLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 13)
        {
            PlayerPrefs.SetInt("Load", 13);
            Application.LoadLevel(4);
        }
    }
    public void FourteenLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 14)
        {
            PlayerPrefs.SetInt("Load", 14);
            Application.LoadLevel(4);
        }
    }
    public void FifteenLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 15)
        {
            PlayerPrefs.SetInt("Load", 15);
            Application.LoadLevel(4);
        }
    }
    public void SixteenLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 16)
        {
            PlayerPrefs.SetInt("Load", 16);
            Application.LoadLevel(4);
        }
    }
    public void SeventeenLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 17)
        {
            PlayerPrefs.SetInt("Load", 17);
            Application.LoadLevel(4);
        }
    }
    public void EighteenLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 18)
        {
            PlayerPrefs.SetInt("Load", 18);
            Application.LoadLevel(4);
        }
    }
    public void NineteenLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 19)
        {
            PlayerPrefs.SetInt("Load", 19);
            Application.LoadLevel(4);
        }
    }
    public void TwentyLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 20)
        {
            PlayerPrefs.SetInt("Load", 20);
            Application.LoadLevel(4);
        }
    }
    public void TwentyoneLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 21)
        {
            PlayerPrefs.SetInt("Load", 21);
            Application.LoadLevel(4);
        }
    }
    public void TwentytwoLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 22)
        {
            PlayerPrefs.SetInt("Load", 22);
            Application.LoadLevel(4);
        }
    }
    public void TwentythreeLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 23)
        {
            PlayerPrefs.SetInt("Load", 23);
            Application.LoadLevel(4);
        }
    }
    public void TwentyfourLevel()
    {
        if (PlayerPrefs.GetInt("Level") >= 24)
        {
            PlayerPrefs.SetInt("Load", 24);
            Application.LoadLevel(4);
        }
    }
    public void NextList()
    {  
        
        if (backl == true )
        {
            nextl = true;
            backl = false;
        }
        else
            nextl = false;
        animator.SetBool("Next", nextl);
        animator.SetBool("Back", backl);
    }

    public void BackList()
    {
        if (nextl == true)
        {
            backl = true;
            nextl = false;
        }
        else
            backl = false;
        
        animator.SetBool("Back", backl);
        animator.SetBool("Next", nextl);
 
    }

    public void Delete()
    {
        PlayerPrefs.SetInt("Level", 0);
    }
    public void Back()
    {
        PlayerPrefs.SetInt("Load", 0);
        Application.LoadLevel(1);
    }


}



 
   

