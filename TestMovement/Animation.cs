using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation: MonoBehaviour
{

    bool pushFlag = false; //スペースキー押しっぱなしかどうか
   // bool jumpFlag = false; //ジャンプ状態かどうか
    bool groundFlag = false; //足が何かに触れているかどうか


    private Animator Playerctl; //Unityにあるアニメーションコントロールを変数に

    // Start is called before the first frame update
    void Start()
    {        
    Playerctl = GetComponent<Animator>(); //コンポーネントを取得し操作できるようにする
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && groundFlag)
        {
            if (pushFlag == false)
            {//押しっぱなしでなければ
                //jumpFlag = true;
                pushFlag = true;
                Playerctl.SetBool("Ani_jumpFlag", true);
            }
        }
        else
        {
            pushFlag = false;
            Playerctl.SetBool("Ani_jumpFlag", false);
        }
    }
}
