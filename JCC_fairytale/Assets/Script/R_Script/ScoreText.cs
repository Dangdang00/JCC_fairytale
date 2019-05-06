using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    int score = 0;

    public void ScoreUp(int number)
    {
        score += number;
        GetComponent<Text>().text = "Score : " + score;
    }
}
