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
    [SerializeField] TableSlots tableSlot;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        if(_navMeshAgent != null)
        {
            _navMeshAgent.SetDestination(RandomNavMeshLocation());
        }
        tableSlot = GameObject.FindObjectOfType<TableSlots>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_navMeshAgent != null && _navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
        {
            tableSlot.resetSpace(Space);

            _navMeshAgent.SetDestination(RandomNavMeshLocation());
        }
    }

    public Vector3 RandomNavMeshLocation()
    {
        tableSlot.GetRandomElement(Space);
        Space = tableSlot.selectedItem;
        Debug.Log("Space = " + Space);
        Vector3 finalPositon = Vector3.zero;
        finalPositon = Space.transform.position;
        
        return finalPositon;
    }
}
