using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogue_R : MonoBehaviour
{
    [SerializeField]
    public Dialogue_22 dialogue;
    private DialogueManager_R theDM_2;

    // Start is called before the first frame update
    void Start()
    {
        theDM_2 = FindObjectOfType<DialogueManager_R>();
        theDM_2.ShowDialogue(dialogue);
    }

}
