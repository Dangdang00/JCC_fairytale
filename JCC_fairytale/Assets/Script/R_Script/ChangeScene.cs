using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    AudioSource audioSource;    // 선언

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();  // 초기화
    }

    public void ChangeGameScene()
    {
        audioSource.Play(); // 실행
        SceneManager.LoadScene("R_Game");
    }
}