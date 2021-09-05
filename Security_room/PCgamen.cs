using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCgamen : MonoBehaviour
{
    public float timer = 0;
    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    public GameObject o4;
    public GameObject o5;
    public GameObject o6;
    public GameObject o7;
    public GameObject sita;
    public GameObject Flag;
    public GameObject PCgamen12;
    public GameObject PCgamen3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Flag.activeSelf) {
            timer += Time.deltaTime;

            if (timer >= 0.5)
            {
                o1.SetActive(true);
                sita.SetActive(false);
            }
            if (timer >= 1)
            {
                o2.SetActive(true);
            }
            if (timer >= 1.5)
            {
                o3.SetActive(true);
            }
            if (timer >= 2)
            {
                o4.SetActive(true);
            }
            if (timer >= 2.5)
            {
                o5.SetActive(true);
            }
            if (timer >= 3)
            {
                o6.SetActive(true);
            }
            if (timer >= 3.5)
            {
                o7.SetActive(true);
            }
            if (timer >= 4)
            {
                PCgamen12.SetActive(false);
                PCgamen3.SetActive(true);
                sita.SetActive(true);
            }
        }
    }
    /*void timeline()
    {
        if (timer == 0.5)
        {
            o1.SetActive(true);
        }
        if (timer == 1)
        {
            o2.SetActive(true);
        }
        if (timer == 1.5)
        {
            o3.SetActive(true);
        }
        if (timer == 2)
        {
            o4.SetActive(true);
        }
        if (timer == 2.5)
        {
            o5.SetActive(true);
        }
        if (timer == 3)
        {
            o6.SetActive(true);
        }
        if (timer == 3.5)
        {
            o7.SetActive(true);
        }
    }*/
}
