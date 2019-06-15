using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_Rank : MonoBehaviour
{
    public void RRank()
    {
        SceneManager.LoadScene("R_Rank");
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
