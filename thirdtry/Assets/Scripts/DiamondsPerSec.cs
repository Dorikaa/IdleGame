using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondsPerSec : MonoBehaviour
{
    public GameObject display;
    public Click click;
    public Items[] items;
    public DiamondMine mine;

    void Start()
    {
        StartCoroutine(AutoTick());
    }

    void Update()
    {
        display.GetComponent<Text>().text = GetDiamondsPerSec() + mine.baseCost + " diamonds/sec";
    }

    public int GetDiamondsPerSec()
    {
        int tick = 0; // we run through our Diamonds/sec upgrades, and if we select one we add its tickValue to our current tick so we get a new value for Diamonds/sec
        foreach (Items item in items)
        {
            tick += item.count * item.tickValue;
        }
        return tick;
    }

    public void AutoDiamondsPerSec()
    {
        click.diamonds += GetDiamondsPerSec();
    }

    IEnumerator AutoTick()
    {
        while (true) // as before, we runs this endlessly to generate the amount of diamonds/sec we are currently having every second
        {
            AutoDiamondsPerSec();
            yield return new WaitForSeconds(1);
        }
    }
}
