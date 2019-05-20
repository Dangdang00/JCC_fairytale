using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {
    GameObject hpGage;
    void Start() {
        this.hpGage = GameObject.Find("HPImage");
        Invoke("WhiteGameWin", 30.0f);
    }
    public void DecreaseHP() {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.2f;
        if (this.hpGage.GetComponent<Image>().fillAmount == 0f) {
            SceneManager.LoadScene("WhiteSnowLose");
        }
    }
    public void WhiteGameWin() {
        SceneManager.LoadScene("WhiteSnowWin");
    }
}
