using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int Rscore = 0;
    int stone = 5;
    int rstone = 10;

    public Text scoreText;

    void Start()
    {
        Rscore = 0;
        stone = 5;
        rstone = 10;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "stone")
        {
            Debug.Log("stone_Touch!");
            Rscore += stone;

        }
        else if(col.gameObject.tag == "rstone")
        {
            Debug.Log("rstone_Touch!");
            Rscore += rstone;
        }

        // 돌멩이 삭제
        Destroy(col.gameObject, 0f);

        // 스코어 출력
        scoreText.text = Rscore.ToString();
    }

    public int GetScore()
    {
        return Rscore;
    }
}
