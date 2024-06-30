using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    private bool _isColliding;
    [SerializeField] Animator _animator;

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
        _isColliding = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _isColliding = false;
    }
}
