using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_Rank : MonoBehaviour
{
    public GameObject R_RankPanel;

    public void RRank()
    {
        R_RankPanel.gameObject.SetActive(true);
    }

    public void RDB()
    {
        R_RankPanel.gameObject.SetActive(false);
    }

    public void WRank()
    {
        SceneManager.LoadScene("W_Rank");
    }

    public void HRank()
    {
        SceneManager.LoadScene("H_Rank");
    }
}
