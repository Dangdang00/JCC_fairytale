using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;

    public Text text;
    public SpriteRenderer rendererSprite;
    public SpriteRenderer rendererBackground;

    private List<string> listSentences;
    private List<Sprite> listSprites;
    private List<Sprite> listBackground;

    private int count; // 대화 진행 상황 카운트.

    private bool talking = false;

  /* #region Singleton
    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion Singleton*/

    // Use this for initialization
    void Start()
    {
        count = 0;
        text.text = " ";
        listSentences = new List<string>();
        listSprites = new List<Sprite>();
        listBackground = new List<Sprite>();
    }

    public void ShowDialogue(Dialogue2 dialogue)
    {
        talking = true;
        for (int i = 0; i < dialogue.sentences.Length; i++)
        {
            listSentences.Add(dialogue.sentences[i]);
            listSprites.Add(dialogue.sprites[i]);
            listBackground.Add(dialogue.background[i]);
        }
        StartCoroutine(Start_DialogueCoroutine());
    }

    public void ExitDialogue()
    {
        text.text = " ";
        count = 0;
        listSentences.Clear();
        listSprites.Clear();
        listBackground.Clear();
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

        for (int i = 0; i < listSentences[count].Length; i++)
        {
            text.text += listSentences[count][i]; // 1글자씩 출력.
            yield return new WaitForSeconds(0.01f);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (talking)
        {
            if (Input.GetMouseButtonDown(0))
            {
                count++;
                text.text =" ";

                if (count == listSentences.Count)
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
