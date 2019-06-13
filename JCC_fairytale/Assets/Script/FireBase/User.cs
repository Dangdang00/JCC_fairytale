using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class User
{
    public string UserId;
    public int UserScore;

    public User()
    {
        UserId = RScoreRegister.UserID;
        UserScore = RScoreRegister.UserScore;
    }
}
