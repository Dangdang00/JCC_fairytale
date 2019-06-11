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

    public void ResultScorePrint(int score)
    {
        ResultScoreText.text = ResultScoreText.ToString();
    }


}
