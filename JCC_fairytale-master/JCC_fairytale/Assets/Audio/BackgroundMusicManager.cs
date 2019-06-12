using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    public AudioClip sfx;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.PlayOneShot(sfx, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
