using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSlots : MonoBehaviour
{
    public static RoomSlots rs;
    public List<GameObject> freeSlots = new List<GameObject>();
    public List<GameObject> takenSlots = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        if (rs == null) 
		  rs = gameObject.GetComponent<RoomSlots>();
    }
}
