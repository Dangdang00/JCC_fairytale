using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMain : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ChangeGameScene()
    {
        SceneManager.LoadScene("R_Menu");
    }
}
