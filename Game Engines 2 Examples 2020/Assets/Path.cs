using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Vector3> waypoints;
    public bool isLooped = true;

    private void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            waypoints.Add(transform.GetChild(i).position);
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;

        for (int i = 0; i < waypoints.Count - 1; i++)
        {
            Gizmos.DrawLine(waypoints[i], waypoints[i + 1]);
            Gizmos.DrawSphere(waypoints[i], 1f);
        }

        if (isLooped)
        {
            Gizmos.DrawLine(waypoints[waypoints.Count - 1], waypoints[0]);
        }

        Gizmos.DrawSphere(waypoints[waypoints.Count - 1], 1f);
    }
}
