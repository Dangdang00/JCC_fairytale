using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WEndScore : MonoBehaviour
{
    int Wscore = 0;
    public Text WScoreText;

    void Update()
    {
        Wscore = Score.Wcount;
        Debug.Log("SnowWhite: " + Wscore);
        WScoreText.text = Wscore.ToString();
    }
}
