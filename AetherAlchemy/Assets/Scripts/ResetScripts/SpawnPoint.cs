using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : TestElement {

    // Properties / Attributes
    public Vector3 startingPosition; // Player position on spawn.
    public Vector3 startingOrientation; // Player orientation on spawn.

    // Service methods.

    // Returns player spawn position.
    public Vector3 GetSpawnPosition()
    {
        return this.startingPosition;
    }

    // Returns player spawn orientation.
    public Vector3 GetSpawnOrientation()
    {
        return this.startingOrientation;
    }
}
