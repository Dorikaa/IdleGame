using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public GameObject diamondsDisplay;
    public GameObject perClickDisplay;
    public float diamonds = 0;
    public int diamonds_per_click = 1;

    void Update()
    {
        diamondsDisplay.GetComponent<Text>().text = "Diamonds: " + diamonds; // every frame we show the current amount of diamonds
        perClickDisplay.GetComponent<Text>().text = diamonds_per_click + " Diamonds/click"; // every frame we show the current amout of diamonds per click for the clickerGame
    }

    public void Clicked()
    {
        diamonds += diamonds_per_click;
    }
}
