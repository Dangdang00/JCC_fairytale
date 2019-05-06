using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    public float moveSpeed = 0.08f;
    public float jumpPower = 350f;

    public GameManager gameManager;

    void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);     // 속도
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpPower);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.name == "WinCollider")
        {
            gameManager.Win();
        }
        else if(col.transform.name == "LoseCollider")
        {
            gameManager.Lose();
        }

        if(col.gameObject.tag == "stone")
        {
            Debug.Log("Touch!");
            //GetStone stone = col.gameObject.GetComponent<GetStone>();
            //ScoreManager.setScore((int)stone.value);
            // 돌멩이 삭제
            Destroy(col.gameObject, 0f);
        }
    }
}
