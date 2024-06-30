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
    [SerializeField] GameObject _audioM;
    [SerializeField] AudioClip _heavyGear;
    bool _playAudio;


    public void PlayAudio()
    {
        _playAudio = true;
        if (_playAudio)
        {
            _audioM.GetComponent<AudioController>().PlaySFX(_heavyGear);
        }
    }

    //Kindaaa bullshi 0w0
    //public void ResetAudio()
    //{
    //    _playAudio = false;
    //}

    public void BtnPressed()
    {
        _moveWall = true;
        _playAudio = true;
        MoveWall();
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
