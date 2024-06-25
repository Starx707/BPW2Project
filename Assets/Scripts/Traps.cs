using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    [SerializeField] private GameObject _pushAble;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pushable"))
        {
            //Destroy(collision.gameObject); //this code would be to destroy the object (and lose the game/level)
            Debug.Log("Position reset");
            collision.GetComponent<PushableObject>().ResetUponDamage(); //Should reset it's pos
        }
    }
}
