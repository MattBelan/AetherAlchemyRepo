using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollyCamera : MonoBehaviour {

    [SerializeField] float radius = 10;
    [SerializeField] float height = 3;
    [SerializeField] float cycleTime = 60;
    [SerializeField] GameObject target;
    [SerializeField] GameObject sun;
    [SerializeField] GameObject moon;
    private float cycleProgress;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0, height, -radius);
	}
	
	// Update is called once per frame
	void Update () {
        cycleProgress += Time.deltaTime;
        if(cycleProgress > cycleTime)
        {
            cycleProgress -= cycleTime;
        }

        float angle = (cycleProgress/cycleTime)*360f;

        sun.transform.rotation = Quaternion.Euler(angle, 30, 0);
        moon.transform.rotation = Quaternion.Euler(angle-180, 30, 0);

        transform.position = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad)*radius, height, -Mathf.Sin(angle * Mathf.Deg2Rad) *radius);

        transform.LookAt(target.transform);
	}
}
