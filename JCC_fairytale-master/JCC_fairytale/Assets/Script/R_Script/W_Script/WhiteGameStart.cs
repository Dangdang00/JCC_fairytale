using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhiteGameStart : MonoBehaviour
{
    public void ChangeFirstScene() {
        SceneManager.LoadScene("WhiteSnowMain");
    }
    public void ChangeSecondScene()
    {
        SceneManager.LoadScene("WhiteSnowGame");
    }
}
