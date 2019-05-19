using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    int score = 0;
    public Text scoreText;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "stone")
        {
            Debug.Log("Touch!");

            // 돌멩이 삭제
            Destroy(col.gameObject, 0f);

            // 스코어 기능
            score += 5;
            scoreText.text = score.ToString();

        }
    }
}
