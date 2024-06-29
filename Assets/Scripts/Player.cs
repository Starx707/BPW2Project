using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool _nearButton = false;
    [SerializeField] private GameObject _connectedBtn;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E)) //this chunk needs to go to the player to call a function that calls onto the wall script to move that wall
        {
            if (_nearButton)
            {
                //Call button pressed function in wall script
                _connectedBtn.GetComponent<BtnWall>().BtnPressed();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BtnWall>())
        {
            _nearButton = true;
        }
        else if (collision.GetComponent<EndingPortal>())
        {
            collision.GetComponent<EndingPortal>().CloseGame();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<BtnWall>())
        {
            _nearButton = false;
        }
    }

}
