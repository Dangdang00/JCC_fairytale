// 책 이미지 변경 및 버튼 보이기
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBookCover : MonoBehaviour
{
    public bool RCover = true;
    public bool WCover;
    //public GameObject btn;

    public GameObject imageObj;
    public Image myImage;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Change_Cover()
    {
        if (RCover == true)
        {
            // 이미지 변경
        }

        if (WCover == true)
        {
            // 이미지 변경
        }
    }
}
