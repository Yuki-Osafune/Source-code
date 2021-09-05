using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aikonn42 : MonoBehaviour
{
    public float timer = 0;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject batu5;
    public GameObject sita;
    public GameObject Flag8;
    public GameObject Flag9;

    void Update()
    {
        if (Flag8.activeSelf)
        {
            timer += Time.deltaTime;

            if (timer >= 0.5)
            {
                m1.SetActive(true);
                sita.SetActive(false);
            }
            if (timer >= 0.7)
            {
                m1.SetActive(false);
                m2.SetActive(true);
                //batu.SetActive(true);
                //sita.SetActive(true);
            }
            if (timer >= 3.0)
            {
                m2.SetActive(false);
                m3.SetActive(true);
                batu5.SetActive(true);
                sita.SetActive(true);
                Flag9.SetActive(true);
            }

        }

        if (Flag8.activeSelf == false)
        {
            m2.SetActive(false);
            m3.SetActive(false);
            batu5.SetActive(false);
        }
    }
}
