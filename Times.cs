using UnityEngine;
using System.Collections;

public class Times : MonoBehaviour {
	
    public float timer = 2;
    int intLoad;
    public int Scene;
    public int Scene1;
    public int Scene2;
    public int Scene3;
    public int Scene4;
    public int Scene5;
    public int Scene6;
    public int Scene7;
    public int Scene8;
    public int Scene9;
    public int Scene10;
    public int Scene11;
    public int Scene12;
    public int Scene13;
    public int Scene14;
    public int Scene15;
    public int Scene16;
    public int Scene17;
    public int Scene18;
    public int Scene19;
    public int Scene20;
    public int Scene21;
    public int Scene22;
    public int Scene23;
    public int Scene24;
	void Update () {
	if (timer > 0) 
	timer -= Time.deltaTime;

    if (timer < 0)
    {
        if (PlayerPrefs.GetInt("Load") == 0)
            Application.LoadLevel(Scene);
        if (PlayerPrefs.GetInt("Load") == 1)
            Application.LoadLevel(Scene1);
        if (PlayerPrefs.GetInt("Load") == 2)
            Application.LoadLevel(Scene2);
        if (PlayerPrefs.GetInt("Load") == 3)
            Application.LoadLevel(Scene3);
        if (PlayerPrefs.GetInt("Load") == 4)
            Application.LoadLevel(Scene4);
        if (PlayerPrefs.GetInt("Load") == 5)
            Application.LoadLevel(Scene5);
        if (PlayerPrefs.GetInt("Load") == 6)
            Application.LoadLevel(Scene6);
        if (PlayerPrefs.GetInt("Load") == 7)
            Application.LoadLevel(Scene7);
        if (PlayerPrefs.GetInt("Load") == 8)
            Application.LoadLevel(Scene8);
        if (PlayerPrefs.GetInt("Load") == 9)
            Application.LoadLevel(Scene9);
        if (PlayerPrefs.GetInt("Load") == 10)
            Application.LoadLevel(Scene10);
        if (PlayerPrefs.GetInt("Load") == 11)
            Application.LoadLevel(Scene11);
        if (PlayerPrefs.GetInt("Load") == 12)
            Application.LoadLevel(Scene12);
        if (PlayerPrefs.GetInt("Load") == 13)
            Application.LoadLevel(Scene13);
        if (PlayerPrefs.GetInt("Load") == 14)
            Application.LoadLevel(Scene14);
        if (PlayerPrefs.GetInt("Load") == 15)
            Application.LoadLevel(Scene15);
        if (PlayerPrefs.GetInt("Load") == 16)
            Application.LoadLevel(Scene16);
        if (PlayerPrefs.GetInt("Load") == 17)
            Application.LoadLevel(Scene17);
        if (PlayerPrefs.GetInt("Load") == 18)
            Application.LoadLevel(Scene18);
        if (PlayerPrefs.GetInt("Load") == 19)
            Application.LoadLevel(Scene19);
        if (PlayerPrefs.GetInt("Load") == 20)
            Application.LoadLevel(Scene20);
        if (PlayerPrefs.GetInt("Load") == 21)
            Application.LoadLevel(Scene21);
        if (PlayerPrefs.GetInt("Load") == 22)
            Application.LoadLevel(Scene22);
        if (PlayerPrefs.GetInt("Load") == 23)
            Application.LoadLevel(Scene23);
        if (PlayerPrefs.GetInt("Load") == 24)
            Application.LoadLevel(Scene24);
    }
}

}
