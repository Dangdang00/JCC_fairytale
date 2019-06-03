using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour {

    public GameObject obj;
    public Transform respawnTr;

    void Start() {
        StartCoroutine(RespawnEnemy());
    }

    IEnumerator RespawnEnemy() {
        while(true) {
            yield return new WaitForSeconds(0.7f);
            float range = (float)Screen.width / (float)Screen.height * Camera.main.orthographicSize;
            Instantiate(obj, respawnTr.position + new Vector3(Random.Range(-range, range), 0, 0), Quaternion.identity);
        }
    }
    
}
