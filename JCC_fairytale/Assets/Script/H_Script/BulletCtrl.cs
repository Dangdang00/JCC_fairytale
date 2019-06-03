using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll) {
        Destroy(this.gameObject);

    }
}
