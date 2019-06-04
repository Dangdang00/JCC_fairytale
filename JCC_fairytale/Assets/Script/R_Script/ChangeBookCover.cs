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

    public GameObject Rbook_Lock;
    //public GameObject Wbook_Lock;
    public GameObject Hbook_Lock;

    public GameObject End_Panel;

    void Update()
    {
        // 백설공주 게임을 성공하면 헨젤과 그레텔 Lock 해제
        if(Go_ending.Wbook == true)
        {
            Hbook.SetActive(true);
            Hbook_Lock.SetActive(false);
        }

        // 백설공주와 헨젤과 그레텔 게임을 모두 성공하면 Lock 해제
        if (GoEnd.Hbook == true && Go_ending.Wbook == true)
        {
            Rbook.SetActive(true);
            Rbook_Lock.SetActive(false);
        }

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

        if (Go_Ending.Rbook && Go_ending.Wbook && GoEnd.Hbook)
        {
            // 딜레이 주기
            End_Panel.SetActive(true);
        }
    }
}
