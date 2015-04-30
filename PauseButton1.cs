using UnityEngine;
using System.Collections;

public class PauseButton1 : MonoBehaviour {

    public GameObject panel1;
    public GameObject times;

    void Start()
    {
        panel1.SetActive(false);
    }
    public void pause() 
    {
        times.SetActive(false);
        panel1.SetActive(true);
        Time.timeScale = 0;       // Пауза
       
    }

    public void playgame()
    {
        times.SetActive(true);
        panel1.SetActive(false);
        Time.timeScale = 1;     // Запуск 
    
    }

    public void menu(int Scene)
    {
        Time.timeScale = 1;      // Запуск 
        Application.LoadLevel(Scene); 
    }


}
