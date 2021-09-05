using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aikonn1 : MonoBehaviour
{
    public float timer = 0;
    public GameObject sita;
    public GameObject Flag;
    public GameObject p1;
    public GameObject p2;
    public GameObject m1;
    public GameObject m2;
    public GameObject batu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Flag.activeSelf)
        {
            timer += Time.deltaTime;

            if (timer >= 0.5)
            {
                p1.SetActive(true);
               sita.SetActive(false);
            }
            if (timer >= 0.7)
            {
                p2.SetActive(true);               
            }
            if (timer >= 1.2)
            {
                p2.SetActive(false);                
            }
            if (timer >= 1.4)
            {
                p1.SetActive(false);
            }
            if (timer >= 1.5)
            {
                m1.SetActive(true);
            }
            if (timer >= 1.7)
            {
                m1.SetActive(false);
                m2.SetActive(true);
                batu.SetActive(true);
                sita.SetActive(true);
            }

        }

        if (Flag.activeSelf == false)
        {
            m2.SetActive(false);
            batu.SetActive(false);
        }

    }
}
