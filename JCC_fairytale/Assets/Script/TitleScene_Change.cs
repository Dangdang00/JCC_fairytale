using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene_Change : MonoBehaviour
{
    public void ChangeTitleScene()
    {
        SceneManager.LoadScene("Title");
    }

    public void ChangeStoryScene()
    {
        SceneManager.LoadScene("story");
    }

    public void ChangeRuleScene()
    {
        SceneManager.LoadScene("Rule");
    }

    public void ChangeChoiceScene()
    {
        SceneManager.LoadScene("Choice");
    }

    public void ChangeLibraryScene()
    {
        SceneManager.LoadScene("Library");
    }

    public void ChangePeopleScene()
    {
        SceneManager.LoadScene("people");
    }
}
