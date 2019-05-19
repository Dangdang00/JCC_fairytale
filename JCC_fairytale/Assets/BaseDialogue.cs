using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Dialogue1
{
    [TextArea]
    public string[] sentences;
    public string[] name;
    public Sprite[] CG;
    public Sprite[] Background;
}

public class BaseDialogue : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private SpriteRenderer sprite_Background;
    [SerializeField] private Text txt_Dialogue;
    [SerializeField] private Text txt_name;

    private bool isDialogue = false; //대화가 진행중인지
    private int count = 0; //얼마나 진행했는ㄷ지

    [SerializeField] private Dialogue1 dialogue;

    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;
        isDialogue = true;
    }

    public void NextDialogue()
    {
            
        txt_Dialogue.text = dialogue.sentences[count];
        txt_name.text = dialogue.name[count];
        sprite_StandingCG.sprite = dialogue.CG[count];
        sprite_Background.sprite = dialogue.Background[count];
        count++;
    }

    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_StandingCG.gameObject.SetActive(_flag);
        sprite_Background.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        txt_name.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }

    void Start()
    {
        ShowDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (count < dialogue.sentences.Length)
                    NextDialogue();

                else
                {
                    SceneManager.LoadScene("Library");
                    OnOff(false);
                }
            }
        }
    }
}
