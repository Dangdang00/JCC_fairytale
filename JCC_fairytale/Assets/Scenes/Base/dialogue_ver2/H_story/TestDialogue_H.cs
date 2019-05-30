using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogue_H : MonoBehaviour
{
    [SerializeField]
    public Dialogue_22 dialogue;
    private Dialogue_H theDM_5;

    // Start is called before the first frame update
    void Start()
    {
        theDM_5 = FindObjectOfType<Dialogue_H>();
        //theDM_5.ShowDialogue(dialogue);
    }
}
