using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMine3 : MonoBehaviour
{
    public GameObject mine;
    public GameObject button;
    public DiamondMine yes;
    public Vector3 getposition;

    public void Create()
    {
        yes.baseCost += 500;
        getposition = new Vector3(mine.transform.position.x, mine.transform.position.y, 1);
        Instantiate(mine, getposition, Quaternion.identity);
        button.gameObject.SetActive(false);
    }
}
