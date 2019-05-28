using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldApple : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("BackSul2");
    }

    void Update()
    {
        transform.Translate(0, -0.1f, 0); // 0.2f의 속도만큼 낙하
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position; //사과의 중심좌표
        Vector2 p2 = this.player.transform.position; // 캐릭터의 중심좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }
    }
}