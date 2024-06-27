using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _creditsPanel;

    bool _creditsShown;

    public void DisplayCredits()
    {
        if (!_creditsShown)
        {
            _creditsPanel.SetActive(true);
        }
        else
        {
            _creditsPanel.SetActive(false);
        }
    }

    public void CloseCredits()
    {
       _creditsPanel.SetActive(false);
    }

}
