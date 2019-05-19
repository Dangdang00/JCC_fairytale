using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject winPanelObj, losePanelObj;

    void Start()
    {
        Time.timeScale = 1f;
    }

    public void Win()
    {
        winPanelObj.SetActive(true);
        Debug.Log("Win!");
        Time.timeScale = 0f;
    }
    
    public void Lose()
    {
        losePanelObj.SetActive(true);
        Debug.Log("Lose!");
        Time.timeScale = 0f;
    }

    public void Replay()
    {
        SceneManager.LoadScene("R_Game");
    }
}
