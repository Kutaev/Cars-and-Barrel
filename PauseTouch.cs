using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	public GUITexture fon;
	bool IsPause = false;
	
	void Update () {
		int count = Input.touchCount;
		for(int i=0; i < count; i++) {
			Touch touch = Input.GetTouch(i);
			if(fon.HitTest(touch.position))
				Application.LoadLevel(1);
			
		}
		
	}
	
	
}