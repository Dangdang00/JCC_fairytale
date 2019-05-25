// 책 이미지 변경 및 버튼 보이기
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBookCover : MonoBehaviour
{
    public bool RCover;
    public bool WCover;
    public GameObject btn;

    void Start()
    {
        RCover = false;
        WCover = false;
        //btn = GameObject.Find("rstone1");
        // 버튼이 안보이게 함
    }

    void Update()
    {
       //if (RCover == true && WCover == true)
        //{
            // 버튼이 보이도록 함
            btn.SetActive(true);
        //}
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
