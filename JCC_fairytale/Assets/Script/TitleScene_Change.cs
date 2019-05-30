using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene_Change : MonoBehaviour
{
   /* AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        //DontDestroyOnLoad(gameObject);
    }
    */
    public void ChangeTitleScene()
    {
        //audioSource.Play();
        SceneManager.LoadScene("Title");
    }

    public void ChangeStoryScene()
    {
       // audioSource.Play();
        SceneManager.LoadScene("story");
    }

    public void ChangeRuleScene()
    {
        //audioSource.Play();
        SceneManager.LoadScene("Rule");
    }

    public void ChangeChoiceScene()
    {
        //audioSource.Play();
        SceneManager.LoadScene("Choice");
    }

    public void ChangeLibraryScene()
    {
        SceneManager.LoadScene("Library");
    }

    public void ChangePeopleScene()
    {
       // audioSource.Play();
        SceneManager.LoadScene("people");
    }
}
