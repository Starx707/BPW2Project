using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform _destination;

    public Transform GetDestination()
    {
        return _destination;
    }
}
