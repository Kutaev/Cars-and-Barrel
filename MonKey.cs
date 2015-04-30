using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MonKey : MonoBehaviour {

    public Text score;
    public static int Gold;
    void Start()
    {
        Gold = 0;
    }
   
    void Update () {
        
        score.text = Gold.ToString();
        
        if (Money.USL == true)
            Gold += 2;
        if (Gold >= 2)
            Money.USL = false;
        
        if (BigMoney.LUS == true)
            Gold += 150;
        if (Gold >= 150)
            BigMoney.LUS = false;





      
	}
}
