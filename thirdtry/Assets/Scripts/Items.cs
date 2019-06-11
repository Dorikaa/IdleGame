using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public UnityEngine.UI.Text info;
    public Click click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    private float baseCost;

    void Start()
    {
        baseCost = cost; // we initialize the baseCost of a mine, we set it from unity to be 500
    }

    void Update()
    {
        info.text = itemName + "\nCost: " + cost + "\nDiamonds: " + tickValue + "/s";
    }

    public void PurchasedItem()
    {
        if ( click.diamonds >= cost ) // if we buy an upgrade, we increase its cost and we substract the amount we paid
        {
            click.diamonds -= cost;
            count += 1;
            cost = Mathf.Round(baseCost + Mathf.Pow(1.15f, count));
        }
    }
}
