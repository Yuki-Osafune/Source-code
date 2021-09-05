using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    public GameObject Flag9;
    public GameObject tobira2;
    void Update()
    {
        if (Flag9.activeSelf == true)
        {
            tobira2.SetActive(true);
        }
    }

}
