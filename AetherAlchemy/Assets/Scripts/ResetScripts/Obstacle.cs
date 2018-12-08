using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : TestElement {

    // Properties / Attributes
    public Vector3 startingPosition; // Obstacle position on spawn.
    public Vector3 startingOrientation; // Obstacle orientation on spawn.
    public Vector3 startingScale; // Obstacle scale on spawn.

    // Check if the obstacle is active in the scene hierarchy.
    public bool IsActive()
    {
        return gameObject.activeInHierarchy;
    }

    // Returns obstacle spawn position.
    public Vector3 GetSpawnPosition()
    {
        return this.startingPosition;
    }
    
    // Returns obstacle spawn orientation.
    public Vector3 GetSpawnOrientation()
    {
        return this.startingOrientation;
    }

    // Returns obstacle scale orientation.
    public Vector3 GetSpawnScale()
    {
        return this.startingScale;
    }
}
