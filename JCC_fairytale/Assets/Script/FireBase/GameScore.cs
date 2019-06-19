using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameScore
{
    public string UserID;
    public int UserScore;

    public string UserID1;
    public int UserScore1;

    public string UserID2;
    public int UserScore2;

    public string UserID3;
    public int UserScore3;

    public string UserID4;
    public int UserScore4;

    public string UserID5;
    public int UserScore5;
    // 멤버변수 5

    public GameScore()
    {
        UserID = PlayerScores.playerName;
        UserScore = PlayerScores.playerScore;
    }
}
