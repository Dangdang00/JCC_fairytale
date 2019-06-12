using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue2
{
    [TextArea]
    public string[] sentences;
    public string[] names;
    public Sprite[] sprites;
    public Sprite[] background;
    public AudioClip[] audioClip;
}
