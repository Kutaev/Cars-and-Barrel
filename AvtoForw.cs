using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AvtoForw : MonoBehaviour {

    public Text ready;
    public float tim;
    int num;
    public int begin;
    public int begend;
    public int end;
    public GameObject panel;
    public GameObject pause;
    public GameObject control;
    public int level;
    public float timer;
    public float speed;
    public Vector3 direction;

    void Start()
    {
        speed = 1.5f;
        control.SetActive(false);
        panel.SetActive(false);
    }
    void Update()
    {
       
        if (num >= -0.1)
        {
            tim -= Time.deltaTime;
            num = (int)tim;
            ready.text = num.ToString();
        }
        if (num <= 0)
        {
            Destroy(ready);
            control.SetActive(true);
            gameObject.transform.Translate(direction * speed * Time.deltaTime);
            if (gameObject.transform.position.z <= begin)
                speed += Time.deltaTime;
            if (gameObject.transform.position.z >= begend)
                speed -= Time.deltaTime;
            if (gameObject.transform.position.z >= end)
            {
                direction.z = 0;
                speed = 0;

                if (timer > 0)
                    timer -= Time.deltaTime;
                if (timer < 0)
                {
                    panel.SetActive(true);
                    pause.SetActive(false);
                    control.SetActive(false);
                }
            }
        }
    }

    public void WIN(int Scene)
    {
        if( PlayerPrefs.GetInt("Level") < level)
        PlayerPrefs.SetInt("Level", level);
        PlayerPrefs.SetInt("Cash", MonKey.Gold);
        Application.LoadLevel(Scene);
    }
}
