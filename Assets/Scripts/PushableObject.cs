using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableObject : MonoBehaviour
{
    private GameObject _currentPortal;
    private bool _timeOut = false;

    [Header("------ SFX ------")]
    [SerializeField] GameObject _audioM;
    [SerializeField] AudioClip _SlimePerish;
    [SerializeField] AudioClip _SlimeTeleport;

    [SerializeField] private Transform _startPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Portal"))
        {
            _currentPortal = collision.gameObject;
            if (_currentPortal != null && _timeOut == false)
            {
                Debug.Log("Cube teleported");
                _audioM.GetComponent<AudioController>().PlaySFX2(_SlimeTeleport);
                transform.position = _currentPortal.GetComponent<Portal>().GetDestination().position;
                _timeOut = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Portal"))
        {
            if (collision.gameObject == _currentPortal)
            {
                _currentPortal = null;
                _timeOut = false;
            }
        }
    }

    public void ResetUponDamage()
    {
        _audioM.GetComponent<AudioController>().PlaySFX2(_SlimePerish);
        transform.position = _startPoint.position;
    }
}
