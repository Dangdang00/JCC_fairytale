using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gold : MonoBehaviour
{
    public GameObject DApple_white_Prefab;
    float span = 1.0f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(DApple_white_Prefab) as GameObject;
            int px = Random.Range(-10, 10);
            go.transform.position = new Vector3(px, 8, 0); //가운데 숫자가 y좌표
        }
    }
}
