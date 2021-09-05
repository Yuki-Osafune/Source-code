using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tansu3 : MonoBehaviour
{
    public GameObject tansu3;
    public Sprite tansu;
    public Sprite tansuopen;
    private bool open = false;
    public GameObject tana;
    public GameObject Book;

    public void ChangeImage()
    {
        if (open)
        {
            tansu3.GetComponent<Image>().sprite = tansu;
            open = false;
            tana.SetActive(false);
            Book.SetActive(false);
        }
        else
        {
            tansu3.GetComponent<Image>().sprite = tansuopen;
            open = true;
            tana.SetActive(true);
            Book.SetActive(true);
        }

    }
}

