using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogue_W : MonoBehaviour
{
    [SerializeField]
    public Dialogue_22 dialogue;
    private DialogueManager_W theDM_3;

    // Start is called before the first frame update
    void Start()
    {
        theDM_3 = FindObjectOfType<DialogueManager_W>();
        theDM_3.ShowDialogue(dialogue);
    }
}
