using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemNavigation : MonoBehaviour
{
    public damageboxmanager damageboxmanager;   
    NavMeshAgent agent;
    Transform destination;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = damageboxmanager.damageboxes[Random.Range(0, damageboxmanager.damageboxes.Length)].transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = destination.position;   
    }
}