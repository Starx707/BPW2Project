using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLvlDoor : MonoBehaviour
{
    //Fake or real door
    //A real door once pushable is in place
    [SerializeField] bool _fakeDoor;
    [SerializeField] private GameManager _gm;

    [Header("------ SFX ------")]
    [SerializeField] GameObject _audioM;
    [SerializeField] AudioClip _doorOpen;

    public void InteractDoor()
    {
        if (_fakeDoor)
        {
            //something funny ig
        }
        else
        {
            //open door sfx
            _audioM.GetComponent<AudioController>().PlaySFX(_doorOpen);
            _gm.GetComponent<GameManager>().NextLvl();
        }
    }
}
