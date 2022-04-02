using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour {

    CharacterMovement cm;
    public Text text;

    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        cm = player.GetComponent<CharacterMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == player && cm.resetNoktasi != new Vector2(transform.position.x,transform.position.y))
        {
            cm.resetNoktasi = transform.position;
            text.text = "Kaydedildi!";
        }
    }
}
