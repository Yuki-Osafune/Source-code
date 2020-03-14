using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{

    const float jumpPower = 8.0f; //ジャンプ力
    const float moveSpeed = 3.0f; //移動速度
    private Rigidbody2D rb; //Rigidbody2Dの入れ物
    bool leftFlag = false;

    bool pushFlag = false; //スペースキー押しっぱなしかどうか
    bool jumpFlag = false; //ジャンプ状態かどうか
    bool groundFlag = false; //足が何かに触れているかどうか

    private Animator Playerctl; //Unityにあるアニメーションコントロールを変数に

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // オブジェクトのRigidbody2Dを取得
        Playerctl = GetComponent<Animator>(); //コンポーネントを取得し操作できるようにする
                                              //この辺で何か悪さしてるっぽい…?
        transform.position = new Vector3(0, 0, 0); //プレイヤーの座標をスタート時に戻す
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            leftFlag = false;
        } //右移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            leftFlag = true;
        }
        //ジャンプ 
        //もし、スペースキーが押されたとき足が何かに触れていたら
        if (Input.GetKeyDown(KeyCode.Space) && groundFlag)
        {
            if (pushFlag == false)
            {//押しっぱなしでなければ
                jumpFlag = true;
                pushFlag = true;                
            }
        }
        else {
            pushFlag = false;            
        } //ジャンプ
    }

    void FixedUpdate()
    {
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
        //もし、ジャンプするとき
        if (jumpFlag) {
            jumpFlag = false;
            rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        }
    }
    void OnTriggerStay2D(Collider2D collision) { //足が何かに触れたら
        groundFlag = true;
        Playerctl.SetBool("Ani_jumpFlag", true);
    }
    void OnTriggerExit2D(Collider2D collision) //足に何も触れなかったら
    {
        groundFlag = false;
        Playerctl.SetBool("Ani_jumpFlag", false);
    }
    
}
