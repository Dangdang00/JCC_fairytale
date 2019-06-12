using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    int HResultScore;
    public Text HResultScoreText;

    void Start()
    {
        HResultScore = 0;    
    }

    void Update()
    {
        HResultScore = GameManager2.score;
        HResultScoreText.text = HResultScore.ToString();
    }
}
