using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameScore
{
    public string UserID;
    public int UserScore;

    public string R_UserID1;
    public int R_UserScore1;

    public string R_UserID2;
    public int R_UserScore2;

    public string R_UserID3;
    public int R_UserScore3;

    public string R_UserID4;
    public int R_UserScore4;

    public string R_UserID5;
    public int R_UserScore5;
    // 멤버변수 5

    public GameScore()
    {
        UserID = PlayerScores.playerName;
        UserScore = PlayerScores.playerScore;
    }
}
