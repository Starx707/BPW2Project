using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private Rigidbody2D _rb;
    Vector2 _movement;

    // Update is called once per frame
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _movement * _moveSpeed * Time.fixedDeltaTime);
    }
  

    //private float horizontal;
    //[SerializeField] private float _speed = 8f;
    //[SerializeField] private float _jumpingPower =  16f;
    //Vector2 _movement;
    //private bool _isFacingRight;

    //[SerializeField] private Rigidbody2D _rb;
    //[SerializeField] private Transform _groundCheck;
    //[SerializeField] private LayerMask _groundLayer;

    // Start is called before the first frame update
    //void Start()
    //{
    //    horizontal = Input.GetAxisRaw("Horizontal");

    //    if (Input.GetButtonDown("Jump") /*&& IsGrounded()*/)
    //    {
    //        _rb.velocity = new Vector2(_rb.velocity.x, _jumpingPower);
    //    }

    //    if (Input.GetButtonUp("Jump") && _rb.velocity.y > 0f)
    //    {
    //        _rb.velocity = new Vector2(_rb.velocity.x, _rb.velocity.y * 0.5f);
    //    }

    //    FlipSprite();
    //}

    //private void FixedUpdate()
    //{
    //    _rb.MovePosition(_rb.position + _movement * _speed * Time.fixedDeltaTime);
    //}

    //private bool IsGrounded()
    //{
    //    return Physics2D.OverlapCircle(_groundCheck.position, 0.2f, _groundLayer);
    //}

    //private void FlipSprite()
    //{
    //    if (_isFacingRight && horizontal < 0f || _isFacingRight && horizontal > 0f)
    //    {
    //        _isFacingRight = !_isFacingRight;
    //        Vector3 localScale = transform.localScale;
    //        localScale.x *= -1f;
    //        transform.localScale = localScale;
    //    }
    //}



}
