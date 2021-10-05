using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Contesters : MonoBehaviour
{
    [Range (1, 500)] public float walkRadius;

    //private variables below
    [SerializeField] NavMeshAgent _navMeshAgent;
    GameObject Space;

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
            TableSlots.instance.takenSpaces.Remove(Space);
            TableSlots.instance.freeSpaces.Add(Space);

            _navMeshAgent.SetDestination(RandomNavMeshLocation());
        }
    }

    public Vector3 RandomNavMeshLocation()
    {
        Space = TableSlots.instance.freeSpaces[Random.Range(0, TableSlots.instance.freeSpaces.Count)];
        TableSlots.instance.freeSpaces.Remove(Space);
        TableSlots.instance.takenSpaces.Add(Space);
        Vector3 finalPositon = Vector3.zero;
        finalPositon = Space.transform.position;
        
        return finalPositon;
    }
}
