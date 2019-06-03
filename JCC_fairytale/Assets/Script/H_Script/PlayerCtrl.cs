using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{

    public int hp = 10;
    public int initHp = 10;
    public Rigidbody2D rb;
    public float speed = 300.0f;

    public Transform tr;

    float h;  //좌,우
    float v;    //위,아래

    void Awake() {
        hp = initHp;
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);
        rb.velocity = dir * speed * Time.deltaTime;


        //화면 밖으로 나가지 못하게
        float size = Camera.main.orthographicSize;
        float offset = 0.4f;

        if (tr.position.y >= size-offset)
        {
            tr.position = new Vector3(tr.position.x, size-offset, 0);
        }
        if (tr.position.y <= -size + offset)
        {
            tr.position = new Vector3(tr.position.x, -size + offset, 0);
        }
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float wSize = Camera.main.orthographicSize * screenRatio;

        if (tr.position.x >= wSize - offset)
        {
            tr.position = new Vector3(wSize - offset, tr.position.y, 0);
        }
        if (tr.position.x <= -wSize + offset)
        {
            tr.position = new Vector3(-wSize + offset, tr.position.y, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.CompareTag("ENEMY")) {
            hp--;
            if(hp <= 0) {
                SceneManager.LoadScene("H_Again");
            }
        }
    }
}
