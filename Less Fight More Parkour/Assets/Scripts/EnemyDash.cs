using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDash : MonoBehaviour {

    public float distance = 20f;
    public float speed = 10f;
    public float coolDown = 5f;

    float anlik = 0f;
    
    public GameObject musicPlayer;

    Rigidbody2D rg;

    private void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    void Update () {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        anlik -= Time.deltaTime;
        Vector3 targetPos = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);

        if (Vector3.Distance(targetPos, transform.position) < distance && anlik < 0f)
        {
            musicPlayer.GetComponent<auidoPlayer>().BossFight();

            rg.AddForce(new Vector2((targetPos.x - transform.position.x) * speed, 0));
            
            anlik = coolDown;
        }
        if (rg.velocity.x > 0f)
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else if (rg.velocity.x < 0f)
        {
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        if(transform.position.y < 0f)
        {
            musicPlayer.GetComponent<auidoPlayer>().Parkour();
            Destroy(this);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<CharacterMovement>().Die();
        }
    }
}
