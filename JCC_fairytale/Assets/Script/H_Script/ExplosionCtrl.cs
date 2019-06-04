using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCtrl : MonoBehaviour
{
    
    void Start()
    {
        Invoke("destory", 0.75f);   
    }
     void destory()
    {
        Destroy(this.gameObject);
    }
}
