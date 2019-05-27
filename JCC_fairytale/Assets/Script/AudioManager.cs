using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject); // 이렇게 하면 다음 scene으로 넘어가도 음악 유
    }
}