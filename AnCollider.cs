using UnityEngine;
using System.Collections;

public class AnCollider : MonoBehaviour {


    public int pas1;
    public int pas2;
    public int pas3;
    public int pas4;
    public int pas5;
    public int pas6;
    public int pas7;
    public int pas8;

    void OnCollisionEnter (Collision Col) {
        if (Col.gameObject.name == "Car02")
        {
            AnimBarrelA.live = pas1;
            AnimBarrelB.live = pas2;
            AnimBarrelC.live = pas3;
            AnimBarrelD.live = pas4;
            AnimBarrelE.live = pas5;
            AnimBarrelF.live = pas6;
            AnimBarrelG.live = pas7;
            AnimBarrelH.live = pas8;
        }
	}
}
