using UnityEngine;
using System.Collections;
public class BakSul_Control : MonoBehaviour
{
    int speed = 6; //스피드 
    float xMove;
    GameObject left;
    GameObject right;
    void Start()
    {
        this.left = GameObject.Find("Walking_Left");
        this.right = GameObject.Find("Walking_Right");
    }
    void Update()
    {
        xMove = 0;
        if (Input.GetMouseButton(1))
            xMove = speed * Time.deltaTime;
        else if (Input.GetMouseButton(0))
            xMove = -speed * Time.deltaTime;
        this.transform.Translate(new Vector3(xMove, 0));

        /*Vector3 worldpos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worldpos.x < 0f) worldpos.x = 0f;
        if (worldpos.y < 0f) worldpos.y = 0f;
        if (worldpos.x > 1f) worldpos.x = 1f;
        if (worldpos.y > 1f) worldpos.y = 1f;
        this.transform.position = Camera.main.ViewportToWorldPoint(worldpos);*/
    }
}

