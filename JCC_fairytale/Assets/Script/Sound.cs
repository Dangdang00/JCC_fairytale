using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource audioSource;    // 선언

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();  // 초기화
        
    }

    public void Audio()
    {
        audioSource.Play(); // 실행
    }
}
