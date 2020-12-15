using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //Vector3 enemyVec;
    public GameObject enemy;//今のポジション
    private Vector3 target = Vector3.zero;
    private GameObject cakeObj;
    public float enemySpeed = 0.05f;
    private float distance_tow;
    Collision collision;
    private float Acount;
    //public GameManager GaMa;//スクリプト参照
    private CakeScript CakeSc;
    Animator ani;
    float count;
    bool isCount = false;


    // Start is called before the first frame update
    void Start()
    {
        distance_tow = Vector3.Distance(enemy.transform.position, target);
        ani = GetComponent<Animator>();
        cakeObj = GameObject.Find("cake");
        CakeSc = cakeObj.GetComponent<CakeScript>();
        ResetTimer();
    }


    // Update is called once per frame
    void Update()
    {
        if(isCount)
        {
            count += Time.deltaTime;
        }
        walk();
        //Debug.Log(enemy.transform.position);
    }

    void walk(){//歩く方向を決める
        //現在の位置
        StartTimer();
        float nowLocation = (count * enemySpeed) / distance_tow;

        //オブジェクトの移動
        transform.position = Vector3.Lerp(enemy.transform.position, target, nowLocation);
        ani.SetBool("Ene01WalkBool",true);
    }

    void OnCollisionStay(Collision collision) {
        if(collision.gameObject.tag == "cake"){
            Debug.Log("cake");
            enemySpeed = 0f;
            Acount += 1;
            ani.SetBool("Ene01EatBool",true);
            if (Acount % 100 == 0)
            {
            CakeSc.cakeHP -= 3;
            } 
        }
    }

    void OnCollisionExit(Collision collision){
        if(collision.gameObject.tag == "cake"){
            enemySpeed = 0.1f;
        }
    }

    void StartTimer()
    {
        isCount = true;
    }
    void StopTimer()
    {
        isCount = false;
    }
    void ResetTimer()
    {
        StopTimer();
        count = 0.0f;
    }
}