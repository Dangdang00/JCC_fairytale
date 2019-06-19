using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_HDB : MonoBehaviour
{
    public static bool H_Rank;

    public void Go_HDB_Scene()
    {
        H_Rank = true;
        SceneManager.LoadScene("H_DB");
    }
}
