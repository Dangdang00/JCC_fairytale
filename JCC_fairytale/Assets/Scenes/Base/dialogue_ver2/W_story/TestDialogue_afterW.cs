using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogue_afterW : MonoBehaviour
{
    [SerializeField]
    public Dialogue_22 dialogue;
    private DialogueManager_afterW theDM_5;

    // Start is called before the first frame update
    void Start()
    {
        theDM_5 = FindObjectOfType<DialogueManager_afterW>();
        //theDM_5.ShowDialogue(dialogue);
    }
}
