using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class college : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent navMeshAgent;
    player player;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = FindObjectOfType<player>();
        navMeshAgent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(player.transform.position);
        transform.rotation = Quaternion.LookRotation(navMeshAgent.velocity.normalized);
    }
}
