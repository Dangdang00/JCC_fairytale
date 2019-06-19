using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HEndScore : MonoBehaviour
{
    public static int Hscore = 0;
    public Text HscoreText;

    void Update()
    {
        Hscore = GameManager2.score;
        Debug.Log("H_and_G: " + Hscore);
        HscoreText.text = Hscore.ToString();
    }
}
