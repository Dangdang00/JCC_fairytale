using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_ending : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("W_Ending");
    }
}