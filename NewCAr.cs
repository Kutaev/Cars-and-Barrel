using UnityEngine;
using System.Collections;

public class NewCAr : MonoBehaviour {

    public GameObject Avto01;
    public GameObject Avto02;
    public GameObject Avto03;

	void Start () {
        if (PlayerPrefs.GetInt("01Car") == 1)
        {
            Avto01.SetActive(true);
        }
        if (PlayerPrefs.GetInt("01Car") == 2)
        {
            Avto02.SetActive(true);
        }

        if (PlayerPrefs.GetInt("01Car") == 3)
        {
            Avto03.SetActive(true);
        }


    }
	
	
	
}
