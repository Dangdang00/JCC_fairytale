using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_Title : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Title");
    }
}
