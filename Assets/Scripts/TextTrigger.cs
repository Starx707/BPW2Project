using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _triggerText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _triggerText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _triggerText.SetActive(false);
    }
}
