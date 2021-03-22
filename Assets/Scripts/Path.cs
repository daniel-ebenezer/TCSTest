using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{

    public Transform[] wayPoints;

    public int currentWayPoint;

    public float speed;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentWayPoint].position, speed * Time.deltaTime);
        
        if(Vector3.Distance(transform.position, wayPoints[currentWayPoint].position)<1f)
        {
            currentWayPoint++;
        }
    }
}
