using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    public GameObject pie;
    public GameObject gold_apple;
    public GameObject cookie;

    public GameObject pie_s;
    public GameObject gold_apple_s;
    public GameObject cookie_s;

    void Update()
    {   
        // 빨간모자 미니게임 승리 시 아이템 이미지 변경
        if(Go_Ending.Rbook)
        {
            pie_s.SetActive(false);
            pie.SetActive(true);
        }

        // 백설공주 미니게임 승리 시 아이템 이미지 변경
        if(Go_ending.Wbook)
        {
            gold_apple_s.SetActive(false);
            gold_apple.SetActive(true);
        }

        // 헨젤과그레텔 미니게임 승리 시 아이템 이비지 변경
        if(GoEnd.Hbook)
        {
            cookie_s.SetActive(false);
            cookie.SetActive(true);
        }
    }
}
