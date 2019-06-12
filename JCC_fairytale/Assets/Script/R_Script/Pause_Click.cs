using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Click : MonoBehaviour
{
    public GameObject Pause_Panel;

    public void Continue()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Pause_Panel.SetActive(false);   // 일시정지 패널 끄기
        }
    }

    public void Go_title() // 타이틀 화면으로 돌아가기
    {
        SceneManager.LoadScene("Title");
    }

    public void Go_First_Story()   // 첫 메인 스토리로 돌아가기
    {
        SceneManager.LoadScene("story");
    }

    public void Go_RStory() // 빨간모자 처음 스토리 보기
    {
        SceneManager.LoadScene("R_Story");
    }

    public void Go_Library()    // 책 선택 화면으로 돌아가기
    {
        SceneManager.LoadScene("Library");
    }

    public void Go_RMenu()
    {
        SceneManager.LoadScene("R_Menu");
    }

    public void Go_Wstory()
    {
        SceneManager.LoadScene("W_story");
    }
    public void Go_HStory()
    {
        SceneManager.LoadScene("H_Story");
    }
}
