using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    private bool _isColliding;
    [SerializeField] Animator _animator;

    [Header("------ SFX ------")]
    [SerializeField] GameObject _audioM;
    [SerializeField] AudioClip _SlimePush;

    private void Update()
    {
        if (_isColliding)
        {
            _animator.SetBool("Moving", true);
        }
        else if (!_isColliding)
        {
            _animator.SetBool("Moving", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _isColliding = true;
            _audioM.GetComponent<AudioController>().PlaySFX2(_SlimePush);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
        {
            _isColliding = false;
        }
    }
}
