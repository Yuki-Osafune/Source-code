using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roommove : MonoBehaviour
{
    public GameObject[] rooms;
    private int now = 0;

    public void Move(string direction)
    {
        rooms[now].SetActive(false); //ルーム[0]非表示
        if (direction == "migi"){
            now += 1;
        }
        if (direction == "hidari")
        {
            now -= 1;
        }

        if (now > 3){
            now = 0;
        } else if(now < 0){
            now = 3;
        }

        rooms[now].SetActive(true); //ルーム[1]表示
        Debug.Log(now);
    }

}
