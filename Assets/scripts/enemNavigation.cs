using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemNavigation : MonoBehaviour
{
    NavMeshAgent agent;
    Transform destination;
    public bool ismaster;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (ismaster)
        {
             destination = FindObjectOfType<CharacterController>().transform;
        }
        else
        {
            destination = GameObject.FindGameObjectWithTag("master").transform;        
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = destination.position;   
    }
}