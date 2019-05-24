using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogue_afterR : MonoBehaviour
{
    [SerializeField]
    public Dialogue_22 dialogue;
    private DialogueManager_afterR theDM_2;

    // Start is called before the first frame update
    void Start()
    {
        theDM_2 = FindObjectOfType<DialogueManager_afterR>();
        theDM_2.ShowDialogue(dialogue);
    }
}
