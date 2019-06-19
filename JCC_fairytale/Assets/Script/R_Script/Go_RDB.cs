using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Go_RDB : MonoBehaviour
{
    public static bool R_Rank;

    public void Go_RDB_Scene()
    {
        R_Rank = true;
        SceneManager.LoadScene("R_DB");
    }
}
