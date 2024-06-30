using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnWall : MonoBehaviour
{
    //private bool _nearButton = false;
    [SerializeField] private GameObject _AssignedWall;
    bool _moveWall = false;
    [SerializeField] private Transform _transformGear;

    [Header("------ SFX ------")]
    [SerializeField] AudioController _audioM;
    [SerializeField] AudioClip _heavyGear;

    private void Awake()
    {
        //_audioM = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager_A>();
    }

    public void BtnPressed()
    {
        _moveWall = true;
        MoveWall();
        _audioM.PlaySFX(_heavyGear);
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
