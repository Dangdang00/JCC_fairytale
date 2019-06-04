using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMain : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("R_Menu");
    }
}
