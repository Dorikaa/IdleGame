using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMine : MonoBehaviour
{
    public GameObject mine;
    public GameObject button;
    public DiamondMine yes;
    public Vector3 getposition;

    public void Create()
    {
        yes.baseCost += 500; // increase the cost of the mines
        getposition = new Vector3(mine.transform.position.x  + 10, mine.transform.position.y, 1); // get the position of the first mine and rearrange this one
        Instantiate(mine, getposition, Quaternion.identity); // inistantiate the new mine
        button.gameObject.SetActive(false); // make the button unavailable after we created the mine
    }
}
