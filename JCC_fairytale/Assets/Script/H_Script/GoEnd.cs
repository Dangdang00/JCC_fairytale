using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoEnd : MonoBehaviour {
    public static bool Hbook;

    public void ChangeGameScene() {
        Hbook = true;   // Treasure.cs와 연결된 변수
        SceneManager.LoadScene("H_Ending");
        }
    }
