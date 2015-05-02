using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GarageMoney : MonoBehaviour {

    public Text moneytext;
    int som;
    int kom;
    int mon;
    public static int cash;
    public Text score;
    public Text buy;
    public Text buy2;

    void Start()
    {
        if (Screen.width == 320)
        {
            score.fontSize = 20;
            moneytext.fontSize = 20;
            buy.fontSize = 20;
            buy2.fontSize = 20;
        }
            
        if (Screen.width == 480)
        {
            score.fontSize = 25;
            moneytext.fontSize = 25;
            buy.fontSize = 25;
            buy2.fontSize = 25;
        }
            
        if (Screen.width == 600)
        {
            score.fontSize = 27;
            moneytext.fontSize = 27;
            buy.fontSize = 27;
            buy2.fontSize = 27;
        }
            
        if (Screen.width == 800)
        {
            score.fontSize = 30;
            moneytext.fontSize = 30;
            buy.fontSize = 30;
            buy2.fontSize = 30;
        }
            
    }
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


