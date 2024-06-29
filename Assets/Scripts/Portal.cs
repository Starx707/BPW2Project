using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform _destination;
    [SerializeField] private GameManager _gm;

    public Transform GetDestination()
    {
        return _destination;
    }

}
