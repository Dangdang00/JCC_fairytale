using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public static int score = 0;

    public Text scoretext;
    public Text highScoretext;
    private string keyString = "highScore";
    private int savedScore = 0;

     void Awake() {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(1920, 1080, true);
        //여기 위 두줄은 게임시작화면에 써줘야되는거
        savedScore = PlayerPrefs.GetInt(keyString, 0);
        highScoretext.text = "HIGH SCORE:" + savedScore.ToString("000000");

    }

    void Start()  {
        score = 0; 
    }

    
    void Update() {
        scoretext.text = "SCORE: " + score.ToString("000000");

        if (score > savedScore)
        {
            PlayerPrefs.SetInt(keyString, score);
        }
    }
}
