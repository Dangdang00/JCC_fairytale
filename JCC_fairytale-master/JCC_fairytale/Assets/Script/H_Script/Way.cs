
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Way : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("H_Way"); //너가 넘기고 싶은 씬
    }
}
