using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController characterController;//①CharacterController型の変数
    private Vector3 Velocity;//キャラクターコントローラーを動かすためのVector3型の変数
    
    public Transform verRot;//縦の視点移動の変数(カメラに合わせる)
    public Transform horRot;//横の視点移動の変数(プレイヤーに合わせる)
    public float MoveSpeed;//移動速度

    //Rigidbodyを変数に入れる
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();

        characterController = GetComponent<CharacterController>();//①CharacterControllerを変数に代入
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");//X_RotationにマウスのX軸の動きを代入する
        float Y_Rotation = Input.GetAxis("Mouse Y");//Y_RotationにマウスのY軸の動きを代入する
        horRot.transform.Rotate(new Vector3(0, X_Rotation * 2, 0));//プレイヤーのY軸の回転をX_Rotationに合わせる
        verRot.transform.Rotate(-Y_Rotation * 2, 0, 0);//カメラのX軸の回転をY_Rotationに合わせる

        if (Input.GetKey(KeyCode.Q))
        {
           Debug.Log(verRot.transform);            
        }

        if (Input.GetKey(KeyCode.W))//Wキーがおされたら 
        {
            characterController.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);//①前方にMoveSpeed＊Time.deltaTimeだけ動かす
        }

        if (Input.GetKey(KeyCode.S))//Sキーがおされたら
        {
            characterController.Move(this.gameObject.transform.forward * -1f * MoveSpeed * Time.deltaTime);//①後方にMoveSpeed＊Time.deltaTimeだけ動かす
        }

        if (Input.GetKey(KeyCode.A))//Aキーがおされたら 
        {
            characterController.Move(this.gameObject.transform.right * -1 * MoveSpeed * Time.deltaTime);//①左にMoveSpeed＊Time.deltaTimeだけ動かす
        }

        if (Input.GetKey(KeyCode.D))//Dキーがおされたら 
        {
            characterController.Move(this.gameObject.transform.right * MoveSpeed * Time.deltaTime);//①右にMoveSpeed＊Time.deltaTimeだけ動かす
        }

        characterController.Move(Velocity);//キャラクターコントローラーをVelocityだけ動かし続ける
        Velocity.y += Physics.gravity.y * Time.deltaTime;//Velocityのy軸を重力*Time.deltaTime分だけ動かす

        
    }
}