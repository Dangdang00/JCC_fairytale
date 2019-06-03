using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoEnd : MonoBehaviour {
    public void ChangeGameScene() {
        SceneManager.LoadScene("H_Ending");
        }
    }
