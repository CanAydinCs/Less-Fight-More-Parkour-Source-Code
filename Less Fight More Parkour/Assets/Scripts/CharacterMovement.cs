using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour {

    public bool canmove = false;

    public float slownessValue = 0f;
    
    public float hiz = 200f;
    public float ziplamaYuksekligi = 100f;
    public float sifirlamaYuksekligi = -15f;

    public bool isGround = false;

    Rigidbody2D rg;
    AudioSource source;

    public Vector2 resetNoktasi;

	void Start () {
        rg = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();

        resetNoktasi = transform.position;
	}

    private void FixedUpdate()
    {
        if (!canmove)
            return;

        float ziplama = rg.velocity.y;

        if(Input.GetButton("Jump") && isGround)
        {
            source.Play();
            ziplama = ziplamaYuksekligi - slownessValue;
        }

        rg.velocity = new Vector2(Input.GetAxis("Horizontal") * hiz * Time.deltaTime, ziplama);
        if (transform.position.y < sifirlamaYuksekligi)
        {
            Die();
        }

        if (rg.velocity.x > 0f)
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else if (rg.velocity.x < 0f)
        {
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
    }

    public void Die()
    {
        transform.position = resetNoktasi;
    }
}