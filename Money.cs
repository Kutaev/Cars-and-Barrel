using UnityEngine;
using System.Collections;

public class Money : MonoBehaviour {

    public GameObject mg;
    public static bool USL = false;
	void OnCollisionEnter ( Collision Col) {
        if (Col.gameObject.name == "Car02")
        {
            Destroy(mg);
            USL = true;
        }
	}

  
}
