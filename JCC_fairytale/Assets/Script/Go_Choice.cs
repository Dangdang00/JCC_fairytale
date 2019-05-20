using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_Choice : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Choice");
    }
}
