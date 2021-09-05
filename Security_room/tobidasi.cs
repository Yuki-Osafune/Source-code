using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tobidasi : MonoBehaviour
{
    public float timer = 0;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    public GameObject m5;
    public GameObject m6;
    //public GameObject batu;
    public GameObject sita;
    public GameObject Flag6;
    public GameObject Flag7;
    public GameObject aikon4;
    public GameObject aikon42;

    void Update()
    {
        if (Flag7.activeSelf)
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
            }
            if (timer >= 1.7)
            {
                m2.SetActive(false);
                m3.SetActive(true);
            }
            if (timer >= 2.7)
            {
                m3.SetActive(false);
                m4.SetActive(true);
            }
            if (timer >= 3.7)
            {
                m4.SetActive(false);
            }
            if (timer >= 4.7)
            {
                m5.SetActive(true);
            }
            if (timer >= 7.0)
            {
                m5.SetActive(false);
                m6.SetActive(true);
                //ここが発動したタイミングで、frag6を消し、

                //ドアロックシステムを起動するようにするため、起動するようのオブジェに置き換える
                aikon4.SetActive(false);
                aikon42.SetActive(true);
            }
            if (timer >= 10.0)
            {
                m6.SetActive(false);
                sita.SetActive(true);
                //Destroy(gameObject.transform.Find("Flag6").gameObject);
                Flag6.SetActive(false);
            }

        }

        /*if (Flag7.activeSelf == false)
        {
            m2.SetActive(false);
            batu.SetActive(false);
        }*/
    }
}
