using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navscript: MonoBehaviour
{
    public Transform goal;
    public NavMeshAgent agent;

    void Start() { agent.destination = goal.position; }
}