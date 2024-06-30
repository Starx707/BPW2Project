using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnPedestal : MonoBehaviour
{
    [SerializeField] private GameObject _activateObject;

    [Header("------ SFX ------")]
    [SerializeField] GameObject _audioM;
    [SerializeField] AudioClip _ButtonPressed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Slime>())
        {
            _activateObject.SetActive(true);
            _audioM.GetComponent<AudioController>().PlaySFX2(_ButtonPressed);
        }
    }
}
