using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    private GameObject currentPortal;

    [Header("------ SFX ------")]
    [SerializeField] GameObject _audioM;
    [SerializeField] AudioClip _TeleportPlayer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(currentPortal != null)
            {
                Debug.Log("Player teleported");
                transform.position = currentPortal.GetComponent<Portal>().GetDestination().position;
                _audioM.GetComponent<AudioController>().PlaySFX(_TeleportPlayer);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Portal"))
        {
            currentPortal = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Portal"))
        {
            if(collision.gameObject == currentPortal)
            {
                currentPortal = null;
            }
        }
    }
}
