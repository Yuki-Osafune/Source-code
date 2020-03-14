using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    GameObject Player;
    GameObject mainCamera;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        mainCamera = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Player.transform.position;
        mainCamera.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z - 10);
    }
}
