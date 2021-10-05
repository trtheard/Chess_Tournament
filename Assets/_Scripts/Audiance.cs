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

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        if(_navMeshAgent != null)
        {
            _navMeshAgent.SetDestination(RandomNavMeshLocation());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_navMeshAgent != null && _navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
        {
            RoomSlots.rs.takenSlots.Remove(Slot);
            RoomSlots.rs.freeSlots.Add(Slot);

            _navMeshAgent.SetDestination(RandomNavMeshLocation());
        }
    }

    public Vector3 RandomNavMeshLocation()
    {
        Slot = RoomSlots.rs.freeSlots[Random.Range(0, RoomSlots.rs.freeSlots.Count)];
        Debug.Log("Slot = " + Slot);
        RoomSlots.rs.freeSlots.Remove(Slot);
        RoomSlots.rs.takenSlots.Add(Slot);
        Vector3 finalPositon = Vector3.zero;
        finalPositon = Slot.transform.position;
        
        return finalPositon;
    }
}
