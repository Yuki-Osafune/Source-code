using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeScript : MonoBehaviour
{
    public int cakeHP = 150;
    private Text Endtext;

    public Text CakeHP;//追加

    // Start is called before the first frame update
    void Start()
    {
        Endtext = GameObject.Find("EndText").GetComponent<Text>();
        Endtext.enabled = false;

        CakeHP = GameObject.Find("CakeHP").GetComponent<Text>();//追加

    }

    // Update is called once per frame
    void Update()
    {
        if(cakeHP <= 0){//ゲームオーバー
            cakeHP =0;
            Endtext.text = "Game Over";
            Endtext.enabled = true;
        }else{
            Endtext.enabled = false;
        }

        CakeHP.text = cakeHP.ToString() + "g";//追加

    }
}
