using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject pauseMenu;

    public void openMenu()
    {
        if(pauseMenu.activeSelf == false)
        {
            pauseMenu.SetActive(true);
            PauseGame();
        }
        else if(pauseMenu.activeSelf == true)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }
    private void PauseGame()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            openMenu();
        }
    }
}
