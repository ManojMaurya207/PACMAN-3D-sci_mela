using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent_packman : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    private UnityEngine.AI.NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    private void Update()
    {
        agent.destination = movePositionTransform.position;
    }



}
