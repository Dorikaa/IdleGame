using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public enum MenuStates { Idle, Clicker };
    public MenuStates currentState;

    public GameObject button;
    public GameObject idleGame;
    public GameObject clickerGame;
    public GameObject mine;

    void Awake()
    {
        currentState = MenuStates.Idle; // sets the first menu to be the MainMenu
        if (GameObject.Find("Click")) // if on the first menu we find the Click Button, we make it invisible
            GameObject.Find("Click").transform.localScale = new Vector3(0, 0, 0);
    }

    void Update()
    {
        switch (currentState) // loop through levels ( Idle and Clicker )
        {
            case MenuStates.Idle:
                idleGame.SetActive(true);
                clickerGame.SetActive(false);
                break;
            case MenuStates.Clicker:
                clickerGame.SetActive(true);
                idleGame.SetActive(false);
                break;
        }
    }

    public void OnClickerGame()
    {
        if (GameObject.Find("Click"))
            GameObject.Find("Click").transform.localScale = new Vector3(0, 0, 0);
        if (GameObject.Find("Mines")) // if we are on the clicker game we want to make the mines unavailable
            GameObject.Find("Mines").transform.localScale = new Vector3(0, 0, 0);
        if ( GameObject.Find("Mines(Clone)") ) // this goes for their clones too
            GameObject.Find("Mines(Clone)").transform.localScale = new Vector3(0, 0, 0);
        if (GameObject.Find("Mines(Clone)"))
            GameObject.Find("Mines(Clone)").transform.localScale = new Vector3(0, 0, 0);
        currentState = MenuStates.Clicker;
    }

    public void OnIdleGame()
    {
        if (GameObject.Find("Click"))
            GameObject.Find("Click").transform.localScale = new Vector3(1, 1, 1);
        if (GameObject.Find("Mines")) // if we are on the idle game we want to make the mines available again
            GameObject.Find("Mines").transform.localScale = new Vector3(1, 1, 1);
        if (GameObject.Find("Mines(Clone)")) // this goes for theirs clones too
            GameObject.Find("Mines(Clone)").transform.localScale = new Vector3(1, 1, 1);
        if (GameObject.Find("Mines(Clone)"))
            GameObject.Find("Mines(Clone)").transform.localScale = new Vector3(1, 1, 1);
        currentState = MenuStates.Idle;
    }
}
