using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("H_Play"); //너가 넘기고 싶은 씬
    }
}