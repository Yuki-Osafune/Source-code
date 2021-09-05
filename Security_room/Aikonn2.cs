using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aikonn2 : MonoBehaviour
{
    public float timer = 0;
    public GameObject m1;
    public GameObject m2;
    public GameObject batu;
    public GameObject sita;
    public GameObject Flag2;

    void Update()
    {
        if (Flag2.activeSelf)
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
                batu.SetActive(true);
                sita.SetActive(true);
            }

        }

        if (Flag2.activeSelf == false)
        {
            m2.SetActive(false);
            batu.SetActive(false);
        }
    }
}
