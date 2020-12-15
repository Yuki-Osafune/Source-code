using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnim : MonoBehaviour
{
    Animator playerAni;
    private bool isJump = true;//ジャンプ判定　ジャンプしたらtrue

    // Start is called before the first frame update
    void Start()
    {

        playerAni = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //アニメーション
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            playerAni.SetBool("RunBool", true);
            //Debug.Log("Run");
        }else{
            playerAni.SetBool("RunBool", false);
        }
        if(Input.GetKey(KeyCode.Mouse0))
        {
            playerAni.SetBool("ShootBool",true);
        }else
        {
            playerAni.SetBool("ShootBool",false);
        }
        /*if(Input.GetKey(KeyCode.Space))
        {
            if(isJump){
            playerAni.SetBool("JumpBool", true);
            isJump = false;
            }
        }

    }

    private void OnTriggerExit(Collider col)
    {
        if(col.tag == "Ground")
        {
            playerAni.SetBool("JumpBool", false);
            isJump = true;
            Debug.Log("Jump end");
        }*/
    }
}
