using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject pauseMenu;

    public void openMenu()
    {
        pauseMenu.SetActive(true);
        PauseGame();
    }
    private void PauseGame()
    {
        Time.timeScale = 0;
    }
}
