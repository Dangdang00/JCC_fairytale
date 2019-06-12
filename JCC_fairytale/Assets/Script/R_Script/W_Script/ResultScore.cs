using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    public Text ResultText;
    int WResultScore = 0;

    void Start()
    {
        WResultScore = 0;
    }

    void Update()
    {
        Debug.Log(WResultScore);
        WResultScore = Score.Wcount;
        ResultText.text = WResultScore.ToString();

    }
}
