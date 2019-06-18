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

    void Start()
    {
        playerScore = REndScore.result_Score;
    }

    public void OnSubmit()
    {
        playerName = nameText.text;
        PostToDatabase();
    }

    public void OnGetScore()
    {
        Debug.Log("Click");
        RetrieveFromDatabase();
    }

    private void UpdateScore()
    {
        //scoreText.text = "Score: " + user.userScore;
        Debug.Log("출력");
        Debug.Log(gameScore.R_UserID1);
        Debug.Log(gameScore.R_UserScore1);
        Debug.Log(gameScore.R_UserID2);
        Debug.Log(gameScore.R_UserScore2);
        Debug.Log(gameScore.R_UserID3);
        Debug.Log(gameScore.R_UserScore3);
        Debug.Log(gameScore.R_UserID4);
        Debug.Log(gameScore.R_UserScore4);
        Debug.Log(gameScore.R_UserID5);
        Debug.Log(gameScore.R_UserScore5);

        scoreText1.text = gameScore.R_UserScore1.ToString();
        scoreText2.text = gameScore.R_UserScore2.ToString();
        scoreText3.text = gameScore.R_UserScore3.ToString();
        scoreText4.text = gameScore.R_UserScore4.ToString();
        scoreText5.text = gameScore.R_UserScore5.ToString();
        nameText1.text = gameScore.R_UserID1;
        nameText2.text = gameScore.R_UserID2;
        nameText3.text = gameScore.R_UserID3;
        nameText4.text = gameScore.R_UserID4;
        nameText5.text = gameScore.R_UserID5;
    }

    private void PostToDatabase()
    {
        // 점수 계산해서 게임스코어에 저장         
        // GameScore ㄹㅏ는 클래스 정의해서 사용 
        //User user = new User(); // 여기가 게임스코어로 바뀌어야함
        GameScore gameScore = new GameScore();

        RestClient.Get<GameScore>("https://jcc-fairytale.firebaseio.com/RedHood.json").Then(response =>
        {
            gameScore = response;
            int[] score = new int[6];
            string[] id = new string[6];

            int itemp;      // score 값 변경할 때 사용
            string stemp;   // id 값 변경할 때 사용

            gameScore.UserID = playerName;
            gameScore.UserScore = playerScore;

            // 값 할당
            score[0] = gameScore.R_UserScore1;
            score[1] = gameScore.R_UserScore2;
            score[2] = gameScore.R_UserScore3;
            score[3] = gameScore.R_UserScore4;
            score[4] = gameScore.R_UserScore5;
            score[5] = gameScore.UserScore;

            id[0] = gameScore.R_UserID1;
            id[1] = gameScore.R_UserID2;
            id[2] = gameScore.R_UserID3;
            id[3] = gameScore.R_UserID4;
            id[4] = gameScore.R_UserID5;
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
            gameScore.R_UserScore1 = score[0];
            gameScore.R_UserScore2 = score[1];
            gameScore.R_UserScore3 = score[2];
            gameScore.R_UserScore4 = score[3];
            gameScore.R_UserScore5 = score[4];

            gameScore.R_UserID1 = id[0];
            gameScore.R_UserID2 = id[1];
            gameScore.R_UserID3 = id[2];
            gameScore.R_UserID4 = id[3];
            gameScore.R_UserID5 = id[4];

            RestClient.Put("https://jcc-fairytale.firebaseio.com/RedHood.json", gameScore);

        });

        Debug.Log("점수: " + playerScore);
        Debug.Log("이름: " + playerName);
    }

    private void RetrieveFromDatabase()
    {
        RestClient.Get<GameScore>("https://jcc-fairytale.firebaseio.com/RedHood.json").Then(response =>
        {
            gameScore = response;
            UpdateScore();
        });
    }
}
