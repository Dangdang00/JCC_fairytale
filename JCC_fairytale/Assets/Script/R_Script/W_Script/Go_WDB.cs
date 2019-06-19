using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Go_WDB : MonoBehaviour
{
    public static bool W_Rank;

    public void Go_WDB_Scene()
    {
        W_Rank = true;
        SceneManager.LoadScene("W_DB");
    }
}
