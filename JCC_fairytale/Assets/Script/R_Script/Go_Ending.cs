using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_Ending : MonoBehaviour
{
    public static bool Rbook;

    public void ChangeScene()
    {
<<<<<<< HEAD
        Rbook = true;   // Treasure.cs와 연결된 변수
        SceneManager.LoadScene("New");
=======
        SceneManager.LoadScene("New");
        Rbook = true;   // Treasure.cs와 연결된 변수
        //SceneManager.LoadScene("R_Ending");
>>>>>>> cd9bbb90864f6f1130e4a4d88af91de767ccdd5c
    }
}
