using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public Click click;
    public UnityEngine.UI.Text info;
    public float cost;
    public float count = 0;
    public int clickPower;
    public string itemName;
    private float baseCost;

    void Start()
    {
        baseCost = cost;
    }
    
    void Update()
    {
        info.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower; 
    }

    public void PurchasedUpgrade()
    {
        if ( click.diamonds >= cost ) // if we buy an upgrade for the clicker game
        {                             // we substract its cost and increase its cost, and also increase the 
            click.diamonds -= cost;   // diamonds_per_click power
            count += 1;
            click.diamonds_per_click += clickPower;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
        }
    }
}
