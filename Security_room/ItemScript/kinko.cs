using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kinko : MonoBehaviour
{
    private string chars = "0123456789";
    public Text[] texts;
    private int[] nows = { 0, 0, 0, 0 };
    public Dialog password;
    public GameObject kinko2;

    public void ChangeText(int n)
    {
        nows[n] += 1;

        if (nows[n] >= chars.Length)
        {
            nows[n] = 0;
        }

        texts[n].text = chars[nows[n]].ToString();
    }
    public void CheckAnswer()
    {
        string answer = "";
        foreach (Text text in texts)
        {
            answer += text.text;
        }

        if(answer == "0712")
        {
            kinko2.SetActive(true);
            password.CloseDialog();
        }

    }
}
