using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RGo_Library : MonoBehaviour
{
   //public GameObject RbookCover;

    public void ChangeGameScene()
    {
        //RbookCover.GetComponent<SpriteRenderer>().sprite = Resources.Load("RbookClear", typeof(Sprite)) as Sprite;

        SceneManager.LoadScene("Library");
    }
    /*public void Click()
    {
        Application.Quit();
    }*/
}
