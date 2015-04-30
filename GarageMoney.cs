using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GarageMoney : MonoBehaviour {

    int som;
    int kom;
    int mon;
    public static int cash;
    public Text score;

    void Update()
    {
        
        mon = PlayerPrefs.GetInt("Save", LevelS.save);
        cash = PlayerPrefs.GetInt("Money");
        cash = cash + mon;
        score.text = cash.ToString();
        PlayerPrefs.SetInt("Save", 0);
        LevelS.save = 0;
        if (VibCarButton.aka == true)
        {
            cash -= VibCarButton.P1;
            VibCarButton.aka = false;
        }

        if (VibCarButton.aka2 == true)
        {
            cash -= VibCarButton.P2;
            VibCarButton.aka2 = false;
        }
         PlayerPrefs.SetInt("Money", cash);
    
    }

    public void clearmoney()
    {
        cash = 0;
        PlayerPrefs.SetInt("Save", 0);
        PlayerPrefs.SetInt("Money", 0);
    }

}


