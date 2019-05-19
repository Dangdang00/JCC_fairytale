using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Dialogue_
{
    [TextArea]
    public string dialogue;
    public Sprite CG_R;
    public Sprite CG_L;
    public string name;
    public Sprite Background;
}

public class changedialogue : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG_R;
    [SerializeField] private SpriteRenderer sprite_StandingCG_L;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private SpriteRenderer sprite_Background;
    [SerializeField] private Text txt_Dialogue;
    [SerializeField] private Text txt_name;

    private bool isDialogue = false; //대화가 진행중인지
    private int count = 0; //얼마나 진행했는ㄷ지

    [SerializeField] private Dialogue_[] dialogue;

    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;
        isDialogue = true;
    }

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        txt_name.text = dialogue[count].name;
        sprite_StandingCG_R.sprite = dialogue[count].CG_R;
        sprite_StandingCG_L.sprite = dialogue[count].CG_L;
        sprite_Background.sprite = dialogue[count].Background;
        count++;
    }

    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_StandingCG_R.gameObject.SetActive(_flag);
        sprite_StandingCG_L.gameObject.SetActive(_flag);
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
                if (count < dialogue.Length)
                    NextDialogue();

                else
                {
                    SceneManager.LoadScene("R_Menu");
                    OnOff(false);
                }
            }
        }
    }
}
