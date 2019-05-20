using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_Story : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("story");
    }
}