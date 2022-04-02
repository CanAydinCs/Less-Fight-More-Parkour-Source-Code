using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auidoPlayer : MonoBehaviour {

    public AudioClip parkour;
    public AudioClip boss;

    AudioSource source;
	
	void Start () {
        source = GetComponent<AudioSource>();
        source.clip = parkour;
        source.Play();
	}
	
	public void BossFight()
    {
        source.Stop();
        source.clip = boss;
        source.Play();
    }

    public void Parkour()
    {
        source.Stop();
        source.clip = parkour;
        source.Play();
    }
}
