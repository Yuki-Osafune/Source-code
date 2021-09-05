using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    public GameObject dialog;
    private GameObject current;

    public void OpenDialog(GameObject detail)
    {
        if (current != null && current.activeSelf)
        {
            current.SetActive(false);
        }
        current = detail;
        ChangeActive(true);
    }

    public void CloseDialog()
    {
        ChangeActive(false);
    }

    private void ChangeActive(bool active)
    {
        dialog.SetActive(active);
        current.SetActive(active);
    }
}