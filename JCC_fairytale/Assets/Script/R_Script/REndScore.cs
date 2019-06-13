using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class REndScore : MonoBehaviour
{   
    int result_Score;
    public Text scoreText;

    void Update()
    {
        result_Score = ScoreText.Rscore;
        Debug.Log("RedHood: " + result_Score);
        scoreText.text = result_Score.ToString();
    }
}
