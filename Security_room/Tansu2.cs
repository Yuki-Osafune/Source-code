using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tansu2 : MonoBehaviour
{
    public GameObject tansu2;
    public Sprite tansu;
    public Sprite tansu22;
    private bool open = false;
    public GameObject posuta;

    public void ChangeImage()
    {
        if (open)
        {
            //tansu2.GetComponent<Image>().sprite = tansu;
           open = false;
            //posuta.SetActive(false);
        }
        else
        {
            tansu2.GetComponent<Image>().sprite = tansu22;
            open = true;
            posuta.SetActive(true);
        }

    }
}

