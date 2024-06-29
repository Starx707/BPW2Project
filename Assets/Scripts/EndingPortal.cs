using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingPortal : MonoBehaviour
{
    public void CloseGame()
    {
        SceneManager.LoadSceneAsync("GameWon"); //Ending game scene
        Debug.Log("Game end");
    }
}
