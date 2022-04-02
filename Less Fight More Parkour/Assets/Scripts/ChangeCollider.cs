using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCollider : MonoBehaviour {

    bool isWhite = true;
    public Animator anim;
    
    public ParticleSystem patlama;
    public bool degistirilebilir = true;

    private void Start()
    {
        ColliderControl();
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.E) && degistirilebilir)
        {
            patlama.Play();
            isWhite = !isWhite;
            anim.SetBool("isWhite", isWhite);
            ColliderControl();
        }
	}

    void ColliderControl()
    {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Beyaz"))
        {
            item.GetComponent<BoxCollider2D>().isTrigger = !isWhite;
        }
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Siyah"))
        {
            item.GetComponent<BoxCollider2D>().isTrigger = isWhite;
        }
    }
}
