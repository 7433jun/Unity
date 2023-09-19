using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int count;
    public Transform[] point;
    public Transform player;
    public NavMeshAgent navMeshAgent;

    void Start()
    {

    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        if (navMeshAgent.velocity == Vector3.zero)
        {
            if (point.Length <= count)
            {
                count = 0;
            }

            navMeshAgent.SetDestination(point[count++].position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌");
    }

    private void OnTriggerStay(Collider other)
    {
        navMeshAgent.SetDestination(player.position);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("충돌 끝");
        navMeshAgent.SetDestination(point[count].position);
    }
}
