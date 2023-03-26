using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
            dir.z = -1.0f;
        if (Input.GetKey(KeyCode.RightArrow))
            dir.z = 1.0f;
        if (Input.GetKey(KeyCode.UpArrow))
            dir.x = -1.0f;
        if (Input.GetKey(KeyCode.DownArrow))
            dir.x = 1.0f;
        navMeshAgent.velocity = dir.normalized * moveSpeed;
        
    }
}