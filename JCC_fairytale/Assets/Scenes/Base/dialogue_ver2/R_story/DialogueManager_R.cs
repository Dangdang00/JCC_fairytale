using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager_R : MonoBehaviour
{

    public static DialogueManager_R instance;

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
        //text.text = " ";
        //Name.text = " ";
        listSentences = new List<string>();
        listNames = new List<string>();
        listSprites_R = new List<Sprite>();
        listSprites_L = new List<Sprite>();
        listBackground = new List<Sprite>();
    }

    public void ShowDialogue(Dialogue_22 dialogue)
    {
        talking = true;
        for (int i = 0; i < dialogue.sentences.Length; i++)
        {
            listBackground.Add(dialogue.background[i]);
            listSprites_R.Add(dialogue.sprites_R[i]);
            listSprites_L.Add(dialogue.sprites_L[i]);
            listSentences.Add(dialogue.sentences[i]);
            listNames.Add(dialogue.names[i]);
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

            if(listSprites_R[count] != listSprites_R[count - 1])
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
                text.text = " ";
                Name.text = " ";

                if (count == listSentences.Count)
                {
                    StopAllCoroutines();
                    ExitDialogue();
                    SceneManager.LoadScene("R_Menu");
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
