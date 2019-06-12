using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject Pause_Panel;

    public void Show_Panel()    // 패널이 보이게 함
    {
        Pause_Panel.SetActive(true);
    }
}
