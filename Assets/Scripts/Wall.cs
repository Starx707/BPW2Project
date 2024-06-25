using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private Transform _newPos;

    public void BtnPressed()
    {
        Debug.Log("Move wall");
    }
}
