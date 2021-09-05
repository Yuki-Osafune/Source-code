using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : MonoBehaviour
{
    public GameObject get;
    public GameObject item;
    public Dialog hint;
    public GameObject detail;
    public GameObject Selected;
    public GameObject Tansuopen;
    public GameObject tana;
    public GameObject Book;
    public GameObject kagiana;

    public void GetItem(){
        get.SetActive(false);
        item.SetActive(true);
        hint.OpenDialog(detail);
    }
    public void SelectItem()
    {
        if (Selected.activeSelf)
        {
            hint.OpenDialog(detail);
        }
        else if (item.activeSelf)
        {
            GameObject[] selects = GameObject.FindGameObjectsWithTag("Selected");
            foreach (GameObject select in selects)
            {
                select.SetActive(false);
            }
            Selected.SetActive(true);
        }
    }

    public void Opentansu()
    {
        if (Selected.activeSelf)
        {
            kagiana.SetActive(false);
            Tansuopen.SetActive(true);
            tana.SetActive(true);
            Book.SetActive(true);
        }
    }

}
