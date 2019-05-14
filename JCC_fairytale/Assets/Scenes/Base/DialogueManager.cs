using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;

    [SerializeField] private SpriteRenderer sprite_Background;

    public Text text;
    public SpriteRenderer rendererSprite;
    public SpriteRenderer rendererDialogueWindow;

    public List<string> listSentences;
    public List<Sprite> listSprites;
    public List<Sprite> listDialogueWindows;

    private int count; //대화 진행 상황 카운트
    public bool talking; //말하는 중인지 아닌지?

    private Dialogue_ dialogue;

    //public Animator falling;
   // public Animator animSprite;
    //public Animator animDialogueWindow;
    // Start is called before the first frame update

    void Start()
    {
        count = 0;
        text.text = "";
        listSentences = new List<string>();
        listSprites = new List<Sprite>();
        listDialogueWindows = new List<Sprite>();
        sprite_Background.gameObject.SetActive(true);
    }

    public void ShowDialogue(Dialogue_ dialogue)
    {
        talking = true;
        sprite_Background.sprite = dialogue.background[count];

        for (int i = 0; i < dialogue.sentences.Length; i++)
        {
            listSentences.Add(dialogue.sentences[i]);
            listSprites.Add(dialogue.sprites[i]);
            listDialogueWindows.Add(dialogue.dialogueWindows[i]);
        }

        StartCoroutine(StartDialogueCoroutine());
    }

    public void ExitDialogue()
    {
        count = 0;
        text.text = "";
        listSentences.Clear();
        listSprites.Clear();
        listDialogueWindows.Clear();
        sprite_Background.gameObject.SetActive(false);
        talking = false;
        //falling.SetBool("Appear", true);
    }

    private void NextDialogue(Dialogue_ dialogue)
    {
        sprite_Background.sprite = dialogue.background[count];
      
    }

    IEnumerator StartDialogueCoroutine()
    {
        if (count > 0)
        {
                if (listSprites[count] != listSprites[count - 1])
                {
                    //animSprite.SetBool("Change", true);
                    yield return new WaitForSeconds(0.1f);
                    rendererSprite.GetComponent<SpriteRenderer>().sprite = listSprites[count];
                    //animSprite.SetBool("Change", false);
                }
            }
        else
        {
            rendererDialogueWindow.GetComponent<SpriteRenderer>().sprite = listDialogueWindows[count];
            rendererSprite.GetComponent<SpriteRenderer>().sprite = listSprites[count];
        }
        
        for (int i = 0; i < listSentences[count].Length; i++)
        {
            text.text += listSentences[count][i]; // 한글자씩 나온다
            yield return new WaitForSeconds(0.04f);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (talking)
            {
                //if (count < listSentences.Count) 
                  //NextDialogue(dialogue);

                count++;
                text.text = " ";

                if (count == listSentences.Count)
                {
                    StopAllCoroutines();
                    ExitDialogue();
                    SceneManager.LoadScene("Library");
                }
                else
                {
                    StopAllCoroutines();
                    StartCoroutine(StartDialogueCoroutine());
                }
            }
        }
    }
}
