using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{
    public int result_Score;
    public Text scoreText;

   public static void Print_Score(int score)
    {
        Debug.Log("Call Function");
        //result_Score = score;
        //scoreText.text = result_Score.ToString();
    }
}
