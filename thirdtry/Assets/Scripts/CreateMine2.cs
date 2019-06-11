using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMine2 : MonoBehaviour
{
    public GameObject mine;
    public GameObject button;
    public Vector3 getposition;
    public DiamondMine yes;

    public void Create()
    {
        yes.baseCost += 500; // increase the cost of the mines
        getposition = new Vector3(mine.transform.position.x + 5, mine.transform.position.y + 4, 1); // get the position of the first mine and rearrange this one
        Instantiate(mine, getposition, Quaternion.identity); // inistantiate the new mine
        button.gameObject.SetActive(false); // make the button unavailable after we created the mine
    }
}
