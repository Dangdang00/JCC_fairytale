using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    static int stoneScore = 0;

    public static void setScore(int value)
    {
        stoneScore += value;
    }

    public static int getScore()
    {
        return stoneScore;
    }

    void OnGUI()
    {
        GUILayout.Label("돌멩이: "+stoneScore.ToString());
    }
}
