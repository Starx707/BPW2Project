using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLvlDoor : MonoBehaviour
{
    //Fake or real door
    //A real door once pushable is in place
    [SerializeField] bool _fakeDoor;
    [SerializeField] private GameManager _gm;

    public void InteractDoor()
    {
        if (_fakeDoor)
        {
            //something funny ig
        }
        else
        {
            _gm.GetComponent<GameManager>().NextLvl();
        }
    }
}
