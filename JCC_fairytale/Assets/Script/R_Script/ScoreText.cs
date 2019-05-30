using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int score = 0;
    int stone = 5;
    int rstone = 10;

    public Text scoreText;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "stone")
        {
            Debug.Log("stone_Touch!");
            score += stone;

        }
        else if(col.gameObject.tag == "rstone")
        {
            Debug.Log("rstone_Touch!");
            score += rstone;
        }

        // 돌멩이 삭제
        Destroy(col.gameObject, 0f);

        // 스코어 출력
        scoreText.text = score.ToString();
    }
}
