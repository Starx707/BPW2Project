using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool _nearButton = false;
    [SerializeField] private GameObject _connectedBtn;
    [SerializeField] private GameManager _gm;
    [SerializeField] private GameObject _UIManger;

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

        if (Input.GetKey(KeyCode.R))
        {
            _gm.GetComponent<GameManager>().ResetLvl();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _UIManger.GetComponent<UIManager>().RevealControlls();
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            _UIManger.GetComponent<UIManager>().HideControlls();
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
