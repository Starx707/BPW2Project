using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnWall : MonoBehaviour
{
    //private bool _nearButton = false;
    [SerializeField] private GameObject _AssignedWall;
    bool _moveWall = false;


    public void BtnPressed()
    {
        Debug.Log("Wall will move");
        _moveWall = true;
        MoveWall();
    }

    private void MoveWall()
    {
        if (_moveWall)
        {
            _AssignedWall.GetComponent<Wall>().MoveSelf();
        }
    }
}
