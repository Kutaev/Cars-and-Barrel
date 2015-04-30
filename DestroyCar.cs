using UnityEngine;
using System.Collections;

public class DestroyCar : MonoBehaviour
{

    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.name == "Car02")
        {
            Application.LoadLevel(5);
        }
    }
}

