using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int Wcount = 0;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        Wcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score : " + Wcount.ToString();
    }
}
