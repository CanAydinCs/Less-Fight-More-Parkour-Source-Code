using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenu;
	
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
    }
	
	
	void Update () {
        if (Input.GetButtonDown("Cancel"))
        {
            if(Time.timeScale >= 0f)
            {
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
                Gorunur();
            }
            else
            {
                DevamEt();
            }
        }
	}

    public void Gorunur()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void DevamEt()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void LevelAc(int index)
    {
        SceneManager.LoadScene(index);
    }
}
