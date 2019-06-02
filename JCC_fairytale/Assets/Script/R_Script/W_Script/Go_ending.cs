using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_ending : MonoBehaviour
{
    public static bool Wbook;

    public void ChangeGameScene()
    {
        Wbook = true;     // Treasure.cs와 연결된 변수
        SceneManager.LoadScene("New");
    }
}