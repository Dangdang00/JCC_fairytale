using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending_Score : MonoBehaviour
{
    int ResultScore;
    public Text ResultScoreText;

    void Start()
    {
        ResultScore = 0;
    }

    void Update()
    {
        ResultScore = ScoreText.Rscore;
        Debug.Log("Test: " + ScoreText.Rscore);
        ResultScoreText.text = ResultScore.ToString();
    }
}
