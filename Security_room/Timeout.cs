using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeout : MonoBehaviour
{
    public float timer = 0;
    public float limit = 3;
    public GameObject obje;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
            if (limit < timer)
            {
                obje.SetActive(false);
                timer = 0;
            }
        
    }
}
