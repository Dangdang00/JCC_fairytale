using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogue : MonoBehaviour
{
    [SerializeField]
    public Dialogue_ dialogue;

    private DialogueManager theDM;
    // Start is called before the first frame update
    void Start()
    {
        theDM = FindObjectOfType<DialogueManager>();
        theDM.ShowDialogue(dialogue);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
