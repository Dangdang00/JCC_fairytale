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
        RCover = false;
        WCover = false;
        //btn = GameObject.Find("rstone1");
        // 버튼이 안보이게 함
        imageObj = GameObject.FindGameObjectWithTag("Rbook");
        myImage = imageObj.GetComponent<Image>();

    }

    void Update()
    {
       //if (RCover == true && WCover == true)
        //{
            // 버튼이 보이도록 함
           //btn.SetActive(true);
        //}

        if(RCover == true)
        {
            myImage.sprite = Resources.Load<Sprite>("RbookClear");
        }
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
