using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Representation of a 'Test' area.
/// </summary>
public class TestArea : TestElement {

    // Properties / Attributes
    
    public SpawnPoint spawnPoint;
    public List<Obstacle> allObstacles;

    // MonoBehavior Methods

	// Use this for initialization
	void Start () {
        // Add the appropriate spawn point to the reference.
		// Add all obstacles with the appropriate test ID to this test area.
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Service methods.

    // Return list of obstacles in the test area.
    public List<Obstacle> GetObstacles()
    {
        return this.allObstacles;
    }

    // Return list of active obstacles.
    public List<Obstacle> GetActiveObstacles()
    {
        List<Obstacle> activeObstacles = new List<Obstacle>();
        foreach (Obstacle element in this.allObstacles)
        {
            if (element.IsActive())
            {
                activeObstacles.Add(element);
            }
        }
        return activeObstacles;
    }

    // Return list of inactive obstacles.
    public List<Obstacle> GetInactiveObstacles()
    {
        List<Obstacle> inactiveObstacles = new List<Obstacle>();
        foreach (Obstacle element in this.allObstacles)
        {
            if (!element.IsActive())
            {
                inactiveObstacles.Add(element);
            }
        }
        return inactiveObstacles;
    }
}
