using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_Library : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Library");
    }
    /*public void Click()
    {
        Application.Quit();
    }*/
}
