using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header ("---- Level select ---")]
    [SerializeField] bool Lvl1;
    [SerializeField] bool Lvl2;
    [SerializeField] bool Lvl3;
    [SerializeField] bool Lvl4;

    private void Start()
    {
        Cursor.visible = false;
    }

    public void NextLvl() //Add if statement/loop
    {
        if (Lvl1)
        {
            SceneManager.LoadSceneAsync("Level2"); //All levels
        }
        else if (Lvl2)
        {
            SceneManager.LoadSceneAsync("Level3"); //All levels
        }
        else if (Lvl3)
        {
            SceneManager.LoadSceneAsync("Level4"); //All levels
        }
    }

    public void ResetLvl()
    {
        if (Lvl1)
        {
            SceneManager.LoadSceneAsync("Level1"); //All levels
        }
        else if (Lvl2)
        {
            SceneManager.LoadSceneAsync("Level2"); //All levels
        }
        else if (Lvl3)
        {
            SceneManager.LoadSceneAsync("Level3"); //All levels
        }
        else if (Lvl4)
        {
            SceneManager.LoadSceneAsync("Level4"); //All levels
        }
    }

    public void GameClear()
    {
        SceneManager.LoadSceneAsync("EndingScreen"); 
    }

    public void ToMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
