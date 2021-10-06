using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSlots : MonoBehaviour
{
    public List<GameObject> freeSlots = new List<GameObject>();
    public List<GameObject> takenSlots = new List<GameObject>();
    public GameObject selectedItem;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    public void resetSlot(GameObject Item)
    {
        freeSlots.Add(Item);
        takenSlots.Remove(Item);
    }

    public void GetRandomSlot(GameObject Item)
    {
        int num = Random.Range(0, freeSlots.Count);
        Item = freeSlots[num];
        selectedItem = Item;
        freeSlots.Remove(Item);
        takenSlots.Add(Item);
    }
}
