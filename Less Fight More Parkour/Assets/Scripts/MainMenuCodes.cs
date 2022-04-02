using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuCodes : MonoBehaviour {

    public GameObject creditsPanel;

    public Image anaMenu;
    public Image creditColor;

    public Text yazi;
    public Text creditText;

    AudioSource source;

    private void Start()
    {
        anaMenu.color = Color.white;
        creditColor.color = Color.black;

        yazi.color = Color.black;
        creditText.color = Color.white;

        source = GetComponent<AudioSource>();
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ButtonSoundPlay();
            anaMenu.color = ReverseColor(anaMenu.color);
            creditColor.color = ReverseColor(creditColor.color);
            yazi.color = ReverseColor(yazi.color);
            creditText.color = ReverseColor(creditText.color);
        }
	}

    Color ReverseColor(Color a)
    {
        if (a == Color.black)
            return Color.white;
        return Color.black;
    }

    public void CreditPanel()
    {
        ButtonSoundPlay();
        creditsPanel.SetActive(!creditsPanel.activeSelf);
    }

    public void Quit()
    {
        ButtonSoundPlay();
        Application.Quit();
    }

    public void StartTheGame()
    {
        ButtonSoundPlay();
        SceneManager.LoadScene(1);
    }

    void ButtonSoundPlay()
    {
        source.Play();
    }
}
