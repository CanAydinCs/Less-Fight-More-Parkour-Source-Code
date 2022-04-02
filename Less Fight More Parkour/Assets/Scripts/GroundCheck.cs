using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    CharacterMovement cm;

	void Start () {
        cm = gameObject.GetComponentInParent<CharacterMovement>();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 && !collision.gameObject.GetComponent<BoxCollider2D>().isTrigger)
        {
            cm.isGround = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8 && !collision.gameObject.GetComponent<BoxCollider2D>().isTrigger)
        {
            cm.isGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            cm.isGround = false;
        }
    }
}
