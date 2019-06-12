using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicCtrl : MonoBehaviour
{
    public AudioClip sfx;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.PlayOneShot(sfx, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
