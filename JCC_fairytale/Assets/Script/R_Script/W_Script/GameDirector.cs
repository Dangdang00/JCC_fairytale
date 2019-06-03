using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    int count = 0;

    GameObject hpGage1;
    GameObject hpGage2;
    GameObject hpGage3;
    void Start()
    {
        count = 0;
        this.hpGage1 = GameObject.Find("HPImage");
        this.hpGage2 = GameObject.Find("HPImage1");
        this.hpGage3 = GameObject.Find("HPImage2");
        Invoke("WhiteGameWin", 30.0f);
    }
    public void DecreaseHP()
    {
        /*this.hpGage.GetComponent<Image>().fillAmount -= 0.2f;
        if (this.hpGage.GetComponent<Image>().fillAmount == 0f) {
            audioSource.Play();
            SceneManager.LoadScene("WhiteSnowLose");
        }*/
        count++;
        if (count == 1)
        {
            Destroy(hpGage3);
        }
        if (count == 2)
        {
            Destroy(hpGage2);
        }
        if (count == 3)
        {
            SceneManager.LoadScene("WhiteSnowLose");
        }
    }
    public void WhiteGameWin()
    {
        SceneManager.LoadScene("WhiteSnowWin");
    }
}
