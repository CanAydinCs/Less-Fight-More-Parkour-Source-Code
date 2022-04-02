using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSetter : MonoBehaviour {

    public GameObject itemPanel;
    public Text[] texts;

    GameObject player;

    int totalWeight = 0;

    Dictionary<string, bool> items = new Dictionary<string, bool>();

    AudioSource source;

	void Start () {
        source = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");

        items.Add("sword", false);
        items.Add("shield", false);
        items.Add("pistol", false);
        items.Add("dash", false);
	}

    public void SetWeight(int itemIndex)
    {
        ButtonSound();

        int index = 100;
        string selectedItem = "";
        switch (itemIndex)
        {
            case 0:
                selectedItem = "sword"; break;
            case 1:
                selectedItem = "shield"; break;
            case 2:
                selectedItem = "pistol"; index = 500; break;
            case 3:
                selectedItem = "dash"; break;
            default:
                break;
        }

        if (items[selectedItem])
        {
            totalWeight -= index / 100;

            texts[itemIndex].text = "not active";
            texts[itemIndex].color = Color.red;
        }
        else
        {
            totalWeight += index / 100;

            texts[itemIndex].text = "active";
            texts[itemIndex].color = Color.green;
        }
        items[selectedItem] = !items[selectedItem];
    }

    public void Save()
    {
        ButtonSound();

        player.GetComponent<CharacterMovement>().slownessValue = totalWeight;
        player.GetComponent<CharacterMovement>().canmove = true;

        itemPanel.SetActive(false);
    }

    void ButtonSound()
    {
        source.Play();
    }
}
