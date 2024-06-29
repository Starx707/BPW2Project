using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool Lvl1;
    [SerializeField] bool Lvl2;
    [SerializeField] bool Lvl3;
    [SerializeField] bool Lvl4;

    public void NextLvl() //Add if statement/loop
    {
        SceneManager.LoadSceneAsync(""); //All levels
    }

    public void GameClear()
    {
        SceneManager.LoadSceneAsync(""); //Ending game scene
    }
}
