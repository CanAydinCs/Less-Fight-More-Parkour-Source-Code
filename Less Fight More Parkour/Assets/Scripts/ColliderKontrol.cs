using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderKontrol : MonoBehaviour {

    GameObject player;

    ChangeCollider ccl;
	
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        ccl = GetComponentInParent<ChangeCollider>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject == player)
        {
            ccl.degistirilebilir = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject == player)
        {
            ccl.degistirilebilir = true;
        }
    }
}
