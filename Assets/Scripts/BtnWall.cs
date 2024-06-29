using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnWall : MonoBehaviour
{
    //private bool _nearButton = false;
    [SerializeField] private GameObject _AssignedWall;
    bool _moveWall = false;
    [SerializeField] private Transform _transformGear;


    public void BtnPressed()
    {
        _moveWall = true;
        MoveWall();
        //Rotate image sprite/button
        _transformGear.Rotate(0, 0f, _transformGear.rotation.z + 1);
    }

    private void MoveWall()
    {
        if (_moveWall)
        {
            _AssignedWall.GetComponent<Wall>().MoveSelf();
        }
    }
}
