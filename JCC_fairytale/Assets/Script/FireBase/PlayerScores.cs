using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScores : MonoBehaviour
{
    public Text scoreText1;
    public Text scoreText2;
    public Text scoreText3;
    public Text scoreText4;
    public Text scoreText5;
    public Text nameText1;
    public Text nameText2;
    public Text nameText3;
    public Text nameText4;
    public Text nameText5;

    public InputField nameText;

    GameScore gameScore = new GameScore();

    public static int playerScore = 0;
    public static string playerName = null;

    string url;

    void Start()
    {
        //playerScore = REndScore.result_Score;
        if (Go_RDB.R_Rank == true)
        {
            Debug.Log("start() 진입");
            playerScore = REndScore.result_Score;
            Debug.Log("점수: " + playerScore);
            url = "RedHood";
        }

        else if (Go_WDB.W_Rank == true)
        {
            playerScore = WEndScore.Wscore;
            url = "SnowWhite";
        }

        else if (Go_HDB.H_Rank == true)
        {
            playerScore = HEndScore.Hscore;
            url = "HanselandGretel";
        }
    }

    public void OnSubmit()
    {
        playerName = nameText.text;
        Debug.Log(Go_RDB.R_Rank);

        PostToDatabase();
    }

    public void OnGetScore()
    {
        Debug.Log("Click");
        RetrieveFromDatabase();
    }

    private void UpdateScore()
    {
        Debug.Log("출력");

        Debug.Log(gameScore.UserID1);
        Debug.Log(gameScore.UserScore1);
        Debug.Log(gameScore.UserID2);
        Debug.Log(gameScore.UserScore2);
        Debug.Log(gameScore.UserID3);
        Debug.Log(gameScore.UserScore3);
        Debug.Log(gameScore.UserID4);
        Debug.Log(gameScore.UserScore4);
        Debug.Log(gameScore.UserID5);
        Debug.Log(gameScore.UserScore5);

        scoreText1.text = gameScore.UserScore1.ToString();
        scoreText2.text = gameScore.UserScore2.ToString();
        scoreText3.text = gameScore.UserScore3.ToString();
        scoreText4.text = gameScore.UserScore4.ToString();
        scoreText5.text = gameScore.UserScore5.ToString();
        nameText1.text = gameScore.UserID1;
        nameText2.text = gameScore.UserID2;
        nameText3.text = gameScore.UserID3;
        nameText4.text = gameScore.UserID4;
        nameText5.text = gameScore.UserID5;

        if (Go_RDB.R_Rank)
            Go_RDB.R_Rank = false;

        else if (Go_WDB.W_Rank)
            Go_WDB.W_Rank = false;

        else if (Go_HDB.H_Rank)
            Go_HDB.H_Rank = false;
    }

    private void PostToDatabase()
    {
        GameScore gameScore = new GameScore();

        Debug.Log("점수: " + playerScore);
        Debug.Log("이름: " + playerName);

        RestClient.Get<GameScore>("https://jcc-fairytale.firebaseio.com/"+ url +".json").Then(response =>
        {
            gameScore = response;
            int[] score = new int[6];
            string[] id = new string[6];

            int itemp;      // score 값 변경할 때 사용
            string stemp;   // id 값 변경할 때 사용

            gameScore.UserID = playerName;
            gameScore.UserScore = playerScore;

            Debug.Log("점수: " + playerScore);
            Debug.Log("이름: " + playerName);

            // 값 할당
            score[0] = gameScore.UserScore1;
            score[1] = gameScore.UserScore2;
            score[2] = gameScore.UserScore3;
            score[3] = gameScore.UserScore4;
            score[4] = gameScore.UserScore5;
            score[5] = gameScore.UserScore;

            id[0] = gameScore.UserID1;
            id[1] = gameScore.UserID2;
            id[2] = gameScore.UserID3;
            id[3] = gameScore.UserID4;
            id[4] = gameScore.UserID5;
            id[5] = gameScore.UserID;

            for (int i = 5; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (score[i] > score[j])
                    {
                        // score 값 치환
                        itemp = score[i];
                        score[i] = score[j];
                        score[j] = itemp;
                        // id 값 치환
                        stemp = id[i];
                        id[i] = id[j];
                        id[j] = stemp;
                    }
                }
            }

            // 값 변경
            gameScore.UserScore1 = score[0];
            gameScore.UserScore2 = score[1];
            gameScore.UserScore3 = score[2];
            gameScore.UserScore4 = score[3];
            gameScore.UserScore5 = score[4];

            gameScore.UserID1 = id[0];
            gameScore.UserID2 = id[1];
            gameScore.UserID3 = id[2];
            gameScore.UserID4 = id[3];
            gameScore.UserID5 = id[4];

            RestClient.Put("https://jcc-fairytale.firebaseio.com/" + url + ".json", gameScore);
        });
    }

    private void RetrieveFromDatabase()
    {
        RestClient.Get<GameScore>("https://jcc-fairytale.firebaseio.com/" + url + ".json").Then(response =>
        {
            gameScore = response;
            UpdateScore();
        });
    }
}
