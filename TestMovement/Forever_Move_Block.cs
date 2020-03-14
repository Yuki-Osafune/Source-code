using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //ずっと移動して、衝突すると反転するようにしておく
    public class Forever_Move_Block : MonoBehaviour
    {
        public float speed = 1;
        Rigidbody2D rbody;

        // Start is called before the first frame update
        void Start()
        {//重力を0にして、衝突時に回転させない
            rbody = GetComponent<Rigidbody2D>();
            rbody.gravityScale = 0;
            rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

        // Update is called once per frame
        void FixedUpdate() //この場合はずっと処理を行う（一定時間ごとに）
            //水平に移動する
        {
            rbody.velocity = new Vector2(speed, 0);
        }

        void OnCollisionEnter2D(Collision2D collision) //衝突したとき
        {
        speed = -speed;　//進む向きを反転する
              //進む向きで左右の向きを変える
        this.GetComponent<SpriteRenderer>().flipX = (speed < 0);
        }
    }

