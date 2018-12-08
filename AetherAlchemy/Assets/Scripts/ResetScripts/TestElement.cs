using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestElement : MonoBehaviour
{

    // Test ID numbers are in this format: ##,
    // where the first digit is the zone index,
    // and the second digit is the test index.

    // Properties / Attributes
    public int zoneIndex; // Zone index.
    public int testIndex; // Test index.

    // Service methods.

    // Compare test ID's.
    public bool IsZone(int otherZoneIndex)
    {
        return this.zoneIndex == otherZoneIndex;
    }

    // Set the test ID.
    public void SetTestID(int otherZoneIndex, int otherTestIndex)
    {
        this.zoneIndex = otherZoneIndex;
        this.testIndex = otherTestIndex;
    }

    // Return the zone index.
    public int GetZoneIndex()
    {
        return this.zoneIndex;
    }

    // Return the combined test value.
    public int GetTestID()
    {
        int zone = (this.zoneIndex + 1) * 10;
        int test = (this.testIndex + 1);
        return zone + test;
    }

}
