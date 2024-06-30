using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnPedestal : MonoBehaviour
{
    [SerializeField] private GameObject _activateObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Slime>())
        {
            _activateObject.SetActive(true);
            //Play portal pop up sound 
        }
    }
}
