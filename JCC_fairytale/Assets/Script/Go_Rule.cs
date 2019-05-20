using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_Rule : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Rule");
    }
}
