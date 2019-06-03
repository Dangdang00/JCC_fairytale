using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGenerator2 : MonoBehaviour
{
    public GameObject DApple_white2_prefab;
    float span = 1.0f;
    float delta = 0;

    void Start()
    {
        span = 1.0f;
        delta = 0.0f;
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(DApple_white2_prefab) as GameObject;
            int px = Random.Range(-10,10);
            go.transform.position = new Vector3(px, 9, 0);
        }
    }
}
