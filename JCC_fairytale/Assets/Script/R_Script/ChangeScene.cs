using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("R_Game");
    }
}