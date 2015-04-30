using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Loading : MonoBehaviour {

    public Text lod;
    string s;
    public float t;
    public int t1;
    bool log;
	
	void Update () {
       
    s = " .";
    if (t > 0)
     t -= Time.deltaTime * 2;
    
    if (t <= 8 && t1 == 0)
     {
         lod.text = lod.text + s.ToString();
         t1 = 1;
     }

    if (t <= 7 && t1 == 1)
    {
        lod.text = lod.text + s.ToString();
        t1 = 2;
    }
    
    if (t <= 6 && t1 == 2)
    {
        lod.text = lod.text + s.ToString();
        t1 = 3;
    }

    if (t <= 5 && t1 == 3)
    {
        lod.text = "Loading";
        t1 = 0;
        t = 8.3f;
    }

      
	}
}
