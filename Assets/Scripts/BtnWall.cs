using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnWall : MonoBehaviour
{
    private bool _nearButton = false;
    [SerializeField] private GameObject _AssignedWall;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) //this chunk needs to go to the player to call a function that calls onto the wall script to move that wall
        {
            if (_nearButton)
            {
                Debug.Log("Button pressed");
                Debug.Log(_nearButton);
                //Call button pressed function in wall script
                //_AssignedWall.GetComponent<Wall>().BtnPressed();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            _nearButton = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            _nearButton = false;
        }
    }
}
