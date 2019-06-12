using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End_Dialogue : MonoBehaviour
{
    public static End_Dialogue instance;
    public Dialogue2 dialogue;

    public Text text;
    public Text Name;
    public SpriteRenderer rendererSprite;
    public SpriteRenderer rendererBackground;

    private List<string> listSentences;
    private List<Sprite> listSprites;
    private List<string> listNames;
    private List<Sprite> listBackground;

    private int count; // 대화 진행 상황 카운트.
    private bool talking = false;

    private AudioClip sfx;
    public AudioSource audioSource;
    private List<AudioClip> listSfx;

    public AudioClip sfx2;
    public AudioSource audioSource2;

    // Use this for initialization
    void Start()
    {
        count = 0;
        listSentences = new List<string>();
        listNames = new List<string>();
        listSprites = new List<Sprite>();
        listBackground = new List<Sprite>();
        listSfx = new List<AudioClip>();
        talking = true;
        audioSource.PlayOneShot(sfx2, 0.5f);
    }

    public void ShowDialogue()
    {
        //talking = true;
        for (int i = 0; i < dialogue.sentences.Length; i++)
        {
            listSentences.Add(dialogue.sentences[i]);
            listSprites.Add(dialogue.sprites[i]);
            listBackground.Add(dialogue.background[i]);
            listNames.Add(dialogue.names[i]);
            listSfx.Add(dialogue.audioClip[i]);
        }
        StartCoroutine(Start_DialogueCoroutine());
    }

    public void ExitDialogue()
    {
        text.text = " ";
        Name.text = " ";
        count = 0;
        listSentences.Clear();
        listSprites.Clear();
        listBackground.Clear();
        listSfx.Clear();
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
                rendererSprite.GetComponent<SpriteRenderer>().sprite = listSprites[count];
            }

            if (listSprites[count] != listSprites[count - 1])
            {
                //yield return new WaitForSeconds(0.1f);
                rendererSprite.GetComponent<SpriteRenderer>().sprite = listSprites[count];
            }
        }
        else
        {
            yield return new WaitForSeconds(0.05f);
            rendererBackground.GetComponent<SpriteRenderer>().sprite = listBackground[count];
            rendererSprite.GetComponent<SpriteRenderer>().sprite = listSprites[count];
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
                audioSource.Stop();
                ShowDialogue();
                count++;
                text.text = " ";
                Name.text = " ";

                if (count >= 7)
                {
                    StopAllCoroutines();
                    ExitDialogue();
                    Application.Quit();
                }
                else
                {
                    sfx = listSfx[count];
                    audioSource.PlayOneShot(sfx, 0.7f);
                    StopAllCoroutines();
                    StartCoroutine(Start_DialogueCoroutine());
                }
            }
        }
    }
}
