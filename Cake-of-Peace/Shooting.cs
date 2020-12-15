using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //追加

public class Shooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float shotSpeed;
    public int shotCount = 30;
    private float shotInterval;
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;

    public Text BulletText;//追加

    void Start()//追加
    {
        BulletText = GameObject.Find("BulletText").GetComponent<Text>();//追加
        audioSource = GetComponent<AudioSource>();
        //StartCoroutine("Relode");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {

            shotInterval += 1;

            if (shotInterval % 5 == 0 && shotCount > 0)
            {
                shotCount -= 1;

                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);

                //射撃されてから3秒後に銃弾のオブジェクトを破壊する.

                Destroy(bullet, 3.0f);
                audioSource.PlayOneShot(sound1);
            }

        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            shotCount = 30;
            audioSource.PlayOneShot(sound2);
        }

        BulletText.text = "チョコボールの残り" + shotCount.ToString() + "個";//追加

    }
}