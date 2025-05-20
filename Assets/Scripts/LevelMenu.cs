using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenu : MonoBehaviour
{
    public GameObject levelMenu;
    public GameObject mainMenu;

    public void showLevels()
    {
        if(mainMenu.activeSelf == true)
        {
            mainMenu.SetActive(false);
        }
        levelMenu.SetActive(true);
    }

    public void hideLevel()
    {
        levelMenu.SetActive(false);
        if(mainMenu.activeSelf == false)
        {
            mainMenu.SetActive(true);
        }
    }
}
