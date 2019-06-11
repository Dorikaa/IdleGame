using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondMine : MonoBehaviour
{
    public int baseCost;
    public DiamondsPerSec diamonds;
    public Click click;

    void Start()
    {
        diamonds.display.GetComponent<Text>().text = baseCost + " diamonds/sec";
        StartCoroutine(AutoTick());
    }

    public int dosome()
    {
        int tick = 0; // we tell a mine to make 500 diamonds a second
        tick += 500;
        return tick;
    }

    public void autoDiamonds()
    {
        click.diamonds += dosome();
    }

    IEnumerator AutoTick()
    {
        while (true) // we run this program endlessly and increase the diamonds by 500 every second
        {
            autoDiamonds();
            yield return new WaitForSeconds(1);
        }
    }
}
