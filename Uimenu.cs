using UnityEngine;
using System.Collections;

public class Uimenu : MonoBehaviour {

   public float timer = 3;
   bool IsButtonDown = false;

   void Start()
   {
       PlayerPrefs.SetInt("Load", 0);
   }
    public void butclick() {
    IsButtonDown = true;
    }
        void Update () {
        if (IsButtonDown) {
        if (timer > 0)
            timer -= Time.deltaTime;
        if (timer < 0)
           Application.LoadLevel (1);
        }
    }
     
	public void exit () {
		Application.Quit();
	}
}
