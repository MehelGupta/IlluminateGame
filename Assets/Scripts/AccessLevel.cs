using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcessLeve : MonoBehaviour
{
    public void loadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void loadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
