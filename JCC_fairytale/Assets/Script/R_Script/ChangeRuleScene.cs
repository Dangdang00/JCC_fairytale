using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeRuleScene : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("R_Rule");
    }
}
