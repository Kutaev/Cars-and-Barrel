using UnityEngine;
using System.Collections;

public class VibCarButton : MonoBehaviour {

    public int P01;
    public int P02;
    public static int P1;
    public static int P2;
    int kuka;
    public static bool aka = false;
    public static bool aka2 = false;
    int Lock;
    int Lock1;
    public int Cars = 1;
    public int Cars2 = 2;
    public int Cars3 = 3;
    public GameObject Kupi;
    public GameObject Kupi1;
    public GameObject Car01;
    public GameObject Car02;
    public GameObject Car03;

    void Start()
    {
        P1 = P01;
        P2 = P02;
        Car02.SetActive(false);
        Car03.SetActive(false);
        Kupi.SetActive(false);
        Kupi1.SetActive(false);
    }


    public void ListCarRight()
    {
        if (!Car02.activeSelf && !Car03.activeSelf)
        {
            if (PlayerPrefs.GetInt("Lock") == 1)
            {
                Car01.SetActive(false);
                Kupi.SetActive(false);
                Kupi1.SetActive(false);
                Car02.SetActive(true);
            }
            else
            {
                Car01.SetActive(false);
                Kupi.SetActive(true);
                Kupi1.SetActive(false);
                Car02.SetActive(true);
            }

        }

        else
        {
            if (Car02.activeSelf)
            {
                if (PlayerPrefs.GetInt("Lock02") == 2)
                {
                    Car02.SetActive(false);
                    Kupi.SetActive(false);
                    Kupi1.SetActive(false);
                    Car03.SetActive(true);
                }
                else
                {
                    Car02.SetActive(false);
                    Kupi.SetActive(false);
                    Kupi1.SetActive(true);
                    Car03.SetActive(true);
                }
            }

        }

    }

    public void ListCarLeft()
    {
        if (Car02.activeSelf)
        {
            Car01.SetActive(true);
            Kupi.SetActive(false);
            Car02.SetActive(false);

        }

        if (Car03.activeSelf)
        {
            if (PlayerPrefs.GetInt("Lock") == 1)
            {
                Car03.SetActive(false);
                Kupi1.SetActive(false);
                Car02.SetActive(true);
            }

            else
            {
                Car02.SetActive(true);
                Kupi1.SetActive(false);
                Kupi.SetActive(true);
                Car03.SetActive(false);
            }
        }
    }


    public void pokupka()
    {
        if (Car02.activeSelf && Kupi.activeSelf)
        {
            if (GarageMoney.cash >= P1)
            {
                aka = true;
                Kupi.SetActive(false);
                Car02.SetActive(true);
                PlayerPrefs.SetInt("Lock", 1);

            }
        }
        if (Car03.activeSelf && Kupi1.activeSelf)
        {
            if (GarageMoney.cash >= P2)
            {
                aka2 = true;
                Kupi1.SetActive(false);
                Car03.SetActive(true);
                PlayerPrefs.SetInt("Lock02", 2);

            }
        }
    }


    public void ReturnCar()
    {
        if (Car01.activeSelf)
        {
            PlayerPrefs.SetInt("01Car", Cars);
            Application.LoadLevel(3);
        }

        if (Car02.activeSelf && !Kupi.activeSelf)
        {

            PlayerPrefs.SetInt("01Car", Cars2);
            Application.LoadLevel(3);
        }

        if (Car03.activeSelf && !Kupi1.activeSelf)
        {
            PlayerPrefs.SetInt("01Car", Cars3);
            Application.LoadLevel(3);

        }
    }

    public void Back()
    {
        Application.LoadLevel(0);
    }

    public void ClCa()
    {
        PlayerPrefs.SetInt("Lock", 0);
        PlayerPrefs.SetInt("Lock02", 0);
    }
}
