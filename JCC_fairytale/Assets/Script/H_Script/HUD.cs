using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUD : MonoBehaviour
{
    public Sprite[] HeartSprites;
    public Image HeartUI;
    private PlayerCtrl player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("PLAYER").GetComponent<PlayerCtrl>();

    }

    private void Update()
    {
        HeartUI.sprite = HeartSprites[player.hp / 6];
    }
}