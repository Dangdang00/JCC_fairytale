using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour {
    public float moveSpeed = 8.0f;
    public float jumpPower = 400f;

    public GameManager gameManager;

    void Start()
    {
        moveSpeed = 8.0f;
        jumpPower = 400f;
    }
    
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
        // 게임에서 이겼을 때
        if(col.transform.name == "WinCollider")
        {
            Time.timeScale = 0f;
            Debug.Log("Win!");
            SceneManager.LoadScene("R_Win");
            //ResultText.Print_Score(ScoreText.score);    //ResultText의 Print함수 호출
            //gameManager.Win();
        }
        // 게임에서 졌을 때
        else if(col.transform.name == "LoseCollider")
        {
            gameManager.Lose();
        }
    }
}
