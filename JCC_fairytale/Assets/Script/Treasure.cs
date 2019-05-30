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
    }
}
