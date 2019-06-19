using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_Rank : MonoBehaviour
{
    public GameObject R_RankPanel;
    public GameObject W_RankPanel;
    public GameObject H_RankPanel;
    
    public static bool R_Rank;
    public static bool W_Rank;
    public static bool H_Rank;

    public void RRank()
    {
        R_Rank = true;
        R_RankPanel.gameObject.SetActive(true);
    }

    public void RDB()
    {
        R_RankPanel.gameObject.SetActive(false);
    }

    public void WRank()
    {
        W_Rank = true;
        W_RankPanel.gameObject.SetActive(true);
    }

    public void WDB()
    {
        W_RankPanel.gameObject.SetActive(false);
    }

    public void HRank()
    {
        H_Rank = true;
        H_RankPanel.gameObject.SetActive(true);
    }

    public void HDB()
    {
        H_RankPanel.gameObject.SetActive(false);
    }
}
