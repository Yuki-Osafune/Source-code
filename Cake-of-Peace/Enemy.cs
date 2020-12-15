using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Enemy : MonoBehaviour
    {

        private GameObject enemy;   //敵オブジェクト
        private HP hp;              //HPクラス
        private EnemyMove enemySpeed;
        public float down = 0.05f;
        public float EnemySpeed = 0.1f;
        public int damage = 1;          //当たったダメージ量
        public int hitPoint = 3;        //HP
        public GameObject hitEffect;

        // Start is called before the first frame update
        void Start()
        {
            enemy = GameObject.FindGameObjectWithTag("enemy");   //敵情報を取得
            hp = enemy.GetComponent<HP>();      //HP情報を取得
            enemySpeed = enemy.GetComponent<EnemyMove>();
    }

        // Update is called once per frame
        void Update()
        {
            //HPが0になったときに敵を破壊するS
            if (hitPoint <= 0)
            {
                Destroy(gameObject);
                //Debug.Log("hitPoint 0");
            }
        }
        private void Damage(int damage)
        {
            //受け取ったダメージ分HPを減らす
            hitPoint -= damage;
        }

        private void DownSpeed(float down)
        {
            EnemySpeed -= down;
        }
        
        void GenerateEffect()
        {
            GameObject effect = Instantiate(hitEffect) as GameObject;

            effect.transform.position = gameObject.transform.position;

            Destroy(effect,0.5f);
        }

    private void OnCollisionEnter ( Collision other )
        {
            //ぶつかったオブジェクトのTagにShellという名前が書いてあったならば（条件）.
            if (other.gameObject.tag == "Shell")
            {
                //Damage関数を呼び出す
                Damage(damage);

                //ぶつかってきたオブジェクトを破壊する.
                Destroy(other.gameObject);

                GenerateEffect();
            }
            if (other.gameObject.tag == "Slow Shell")
            {
                Damage(damage);

                DownSpeed(down);

                Destroy(other.gameObject);
            }
        }
    }
