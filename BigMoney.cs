using UnityEngine;
using System.Collections;

public class BigMoney : MonoBehaviour {

    public static bool LUS = false;
    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.name == "Car02")
        {
            Destroy(gameObject);
            LUS = true;
        }
    }

}
