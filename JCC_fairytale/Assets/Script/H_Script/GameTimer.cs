using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour {
    public static float time;
    void Start(){
        time = 40f;
    }

    void Update(){
        if (time != 0){
            time -= Time.deltaTime;
            if (time <= 0){
                time = 0;
                SceneManager.LoadScene("H_End");
            }
        }

        int t = Mathf.FloorToInt(time);
        Text Timer = GetComponent<Text>();
        Timer.text = "Time: " + t.ToString();
    }
}