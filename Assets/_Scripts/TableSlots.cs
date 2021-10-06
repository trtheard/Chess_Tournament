using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSlots : MonoBehaviour
{
    public List<GameObject> freeSpaces = new List<GameObject>();
    public List<GameObject> takenSpaces = new List<GameObject>();
    public GameObject selectedItem;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void resetSpace(GameObject Item)
    {
        freeSpaces.Add(Item);
        takenSpaces.Remove(Item);
    }

    public void GetRandomElement(GameObject Item)
    {
        int num = Random.Range(0, freeSpaces.Count);
        Item = freeSpaces[num];
        selectedItem = Item;
        freeSpaces.Remove(Item);
        takenSpaces.Add(Item);
    }
}
