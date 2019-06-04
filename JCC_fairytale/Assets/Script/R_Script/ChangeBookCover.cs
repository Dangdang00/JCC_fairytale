// 책 이미지 변경 및 버튼 보이기
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBookCover : MonoBehaviour
{
    public GameObject Rbook;
    public GameObject Wbook;
    public GameObject Hbook;
    public GameObject Rbook_Clear;
    public GameObject Wbook_Clear;
    public GameObject Hbook_Clear;

    void Update()
    {
        // 빨간모자 미니게임 성공시 책 이미지 변경
        if (Go_Ending.Rbook)
        {
            Rbook.SetActive(false);
            Rbook_Clear.SetActive(true);
        }

        // 백설공주 미니게임 성공시 책 이미지 변경
        if (Go_ending.Wbook)
        {
            Wbook.SetActive(false);
            Wbook_Clear.SetActive(true);
        }

        // 헨젤과 그레텔 성공시 책 이미지 변경
        if (GoEnd.Hbook)
        {
            Hbook.SetActive(false);
            Hbook_Clear.SetActive(true);
        }

    }
}
