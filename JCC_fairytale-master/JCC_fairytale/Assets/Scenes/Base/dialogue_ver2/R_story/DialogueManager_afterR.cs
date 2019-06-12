﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager_afterR : MonoBehaviour
{
    public static DialogueManager_afterR instance;
    public Dialogue_22 dialogue;

    public Text text;
    public Text Name;
    public SpriteRenderer rendererSprite_L;
    public SpriteRenderer rendererSprite_R;
    public SpriteRenderer rendererBackground;

    private List<string> listSentences;
    private List<string> listNames;
    private List<Sprite> listSprites_R;
    private List<Sprite> listSprites_L;
    private List<Sprite> listBackground;

    private int count; // 대화 진행 상황 카운트.
    private bool talking = false;

    /*private AudioClip sfx;
    public AudioSource audioSource;
    private List<AudioClip> listSfx;
    */

    // Use this for initialization
    public void Start()
    {
        count = -1;
        //text.text = " ";
        //Name.text = " ";
        listSentences = new List<string>();
        listNames = new List<string>();
        listSprites_R = new List<Sprite>();
        listSprites_L = new List<Sprite>();
        listBackground = new List<Sprite>();
        //listSfx = new List<AudioClip>();
        talking = true;
    }

    public void ShowDialogue()
    {
        //talking = true;
        for (int i = 0; i < dialogue.sentences.Length; i++)
        {
            listBackground.Add(dialogue.background[i]);
            listSprites_R.Add(dialogue.sprites_R[i]);
            listSprites_L.Add(dialogue.sprites_L[i]);
            listSentences.Add(dialogue.sentences[i]);
            listNames.Add(dialogue.names[i]);
            //listSfx.Add(dialogue.audioClips[i]);
        }
        StartCoroutine(Start_DialogueCoroutine());
    }

    public void ExitDialogue()
    {
        text.text = " ";
        Name.text = " ";
        count = 0;
        listSentences.Clear();
        listNames.Clear();
        listSprites_R.Clear();
        listSprites_L.Clear();
        listBackground.Clear();
        //listSfx.Clear();
        talking = false;
    }


    IEnumerator Start_DialogueCoroutine()
    {
        if (count > 0)
        {
            if (listBackground[count] != listBackground[count - 1])
            {
                //yield return new WaitForSeconds(0.2f);
                rendererBackground.GetComponent<SpriteRenderer>().sprite = listBackground[count];

            }

            if (listSprites_L[count] != listSprites_L[count - 1])
            {
                //yield return new WaitForSeconds(0.1f);
                rendererSprite_L.GetComponent<SpriteRenderer>().sprite = listSprites_L[count];
            }

            if (listSprites_R[count] != listSprites_R[count - 1])
            {
                //yield return new WaitForSeconds(0.1f);
                rendererSprite_R.GetComponent<SpriteRenderer>().sprite = listSprites_R[count];
            }
        }
        else
        {
            yield return new WaitForSeconds(0.05f);
            rendererBackground.GetComponent<SpriteRenderer>().sprite = listBackground[count];
            rendererSprite_R.GetComponent<SpriteRenderer>().sprite = listSprites_R[count];
            rendererSprite_L.GetComponent<SpriteRenderer>().sprite = listSprites_L[count];
        }
        Name.text += listNames[count];
        text.text += listSentences[count];

    }
    // Update is called once per frame
    void Update()
    {
        if (talking)
        {

            if (Input.GetMouseButtonDown(0))
            {
                ShowDialogue();
                count++;
                text.text = " ";
                Name.text = " ";
                //sfx = listSfx[count];
               //audioSource.PlayOneShot(sfx, 0.7f);

                if (count >= 10)
                {
                    StopAllCoroutines();
                    ExitDialogue();
                    SceneManager.LoadScene("Library");
                }
                else
                {
                    StopAllCoroutines();
                    StartCoroutine(Start_DialogueCoroutine());
                }
            }
        }
    }
}
