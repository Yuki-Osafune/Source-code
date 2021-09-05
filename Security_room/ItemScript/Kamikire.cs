using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamikire : MonoBehaviour
{
    public GameObject get;
    public GameObject item;
    public Dialog hint;
    public GameObject detail;
    public GameObject Selected;
    public GameObject Flag;

    public void GetItem()
    {
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

    public void PCgamen()
    {
        if (Selected.activeSelf)
        {
            Flag.SetActive(true);
        }
    }

}
