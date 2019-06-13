using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RScoreRegister : MonoBehaviour
{
    public InputField nameText;

    User user = new User();

    public static int UserScore;
    public static string UserID;

    void Start()
    {
        UserScore = ScoreText.Rscore;
    }
    /*
    public void OnShubmit()
    {
        UserID = nameText.text;
        PostToDatabase();
    }

    private void PostToDatabase()
    {
        Debug.Log("PostToDatabase(): " + UserID + "," + UserScore);
        User user = new User();
        RestClient.Put("https://ranking-study.firebaseio.com/" + UserID + ".json", user);
        Debug.Log(UserID + ", " + UserScore);
    }

    private void RetrieveFromDatabase()
    {
        RestClient.Get<User>("https://jcc-fairytale.firebaseio.com/" + nameText + ".json").Then(response =>
        {
            user = response;
            //UpdateScore();
        });
    }*/
}
