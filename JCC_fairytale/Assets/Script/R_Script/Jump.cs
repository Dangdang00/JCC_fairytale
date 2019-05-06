using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    bool isJumping = false;

    void Update()
    {
        /*GetMousButton(0)하면 누르면 계속 점프*/
        if (Input.GetMouseButtonDown(0))
        {
            if (isJumping == false)
            {
                isJumping = true;
                Debug.Log("true!");
                GetComponent<Rigidbody2D>().AddForce(Vector3.up * 350f);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
       // if (col.transform.name == "Ground")
       // {
            isJumping = false;
            Debug.Log("False!");
       // }
    }
}