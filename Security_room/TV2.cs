using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TV2 : MonoBehaviour
{
    public GameObject Flag4;
    public GameObject TV22;
    public Sprite TV3;

    // Update is called once per frame
     void Update()
    {
        if (Flag4.activeSelf)
        {
            TV22.GetComponent<Image>().sprite = TV3;
        }
    }
}
