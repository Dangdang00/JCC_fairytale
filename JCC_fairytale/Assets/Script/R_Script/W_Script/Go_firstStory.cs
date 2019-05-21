using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_firstStory : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("W_story");
    }
}
