using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    public static Text ResultText;
    public static int WResultScore = 0;

    void Start()
    {
        WResultScore = 0;
    }

    public static void setWResultScore(int score)
    {
        Debug.Log("값 받음" + score);
        WResultScore = score;
        Debug.Log("값 대입" + WResultScore);
        //ResultText.text = WResultScore.ToString();
    }


    /*void Update()
    {
        Debug.Log(WResultScore);
        printResultScore();
    }

    public void printResultScore()
    {
        ResultText.text = WResultScore.ToString();
    }*/
}
