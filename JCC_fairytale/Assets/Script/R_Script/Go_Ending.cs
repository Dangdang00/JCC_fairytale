using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_Ending : MonoBehaviour
{
    public static bool Rbook;

    public void ChangeScene()
    {
        Rbook = true;   // Treasure.cs와 연결된 변수
        SceneManager.LoadScene("R_Ending");
    }
}
