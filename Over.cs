using UnityEngine;
using System.Collections;

public class Over : MonoBehaviour {

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
	public void restart() 
    {
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
  
	}

    public void menu(int Scene)
    {
        Application.LoadLevel(Scene);
    }
}
