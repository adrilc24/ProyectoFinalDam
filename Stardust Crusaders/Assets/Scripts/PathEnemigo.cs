﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathEnemigo : MonoBehaviour
{
    [SerializeField] WaveConfig waveConfig;
    List<Transform> waypoints;
    [SerializeField] float speed = 2f;
    int waypointIndedex = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        waypoints = waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndedex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (waypointIndedex <= waypoints.Count - 1)
        {
            var targetPosition = waypoints[waypointIndedex].transform.position;
            var movementThisFrame = speed * Time.deltaTime;

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);

            if (transform.position == targetPosition)
            {
                waypointIndedex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
