using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject losePanelObj;

    void Start()
    {
        Time.timeScale = 1f;
    }

    /*public void Win()
    {
        winPanelObj.SetActive(true);    // 오브젝트 활성화
        Debug.Log("Win!");
        Time.timeScale = 0f;
    }*/

    public void Lose()
    {
        losePanelObj.SetActive(true);
        Debug.Log("Lose!");
        Time.timeScale = 0f;
    }
     
  /*  public void showScore()
    {
        ScorePanelObj.SetActive(true);
        Debug.Log("Score");
        Time.timeScale = 0f;
    }*/

    public void Replay()
    {
        SceneManager.LoadScene("R_Game");
    }
}
