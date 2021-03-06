using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Audiance : MonoBehaviour
{
    [Range (1, 500)] public float walkRadius;

    //private variables below
    [SerializeField] NavMeshAgent _navMeshAgent;
    GameObject Slot;
    [SerializeField] RoomSlots roomSlot;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        if(_navMeshAgent != null)
        {
            _navMeshAgent.SetDestination(RandomNavMeshLocation());
        }
        roomSlot = GameObject.FindObjectOfType<RoomSlots>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_navMeshAgent != null && _navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
        {
            roomSlot.resetSlot(Slot);

            _navMeshAgent.SetDestination(RandomNavMeshLocation());
        }
    }

    public Vector3 RandomNavMeshLocation()
    {
        roomSlot.GetRandomSlot(Slot);
        Slot = roomSlot.selectedItem; 
        Debug.Log("Slot = " + Slot);
        Vector3 finalPositon = Vector3.zero;
        finalPositon = Slot.transform.position;
        
        return finalPositon;
    }
}
