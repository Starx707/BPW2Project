using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private Transform _newPos;
    [SerializeField] int _moveSpeed = 25;

    public void MoveSelf()
    {
        transform.position = Vector3.MoveTowards(transform.position, _newPos.position, _moveSpeed * Time.deltaTime); //_newPos.position
    }



}
