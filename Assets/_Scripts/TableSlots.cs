using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSlots : MonoBehaviour
{
    public static TableSlots instance;
    public List<GameObject> freeSpaces = new List<GameObject>();
    public List<GameObject> takenSpaces = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) 
		  instance = gameObject.GetComponent<TableSlots>();
    }
}
