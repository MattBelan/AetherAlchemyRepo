using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustBrightness : MonoBehaviour {

	public Slider brightnessSlider;
	public float newBrightness;
	// Use this for initialization
	void Start () {
		brightnessSlider.value = 0.75f;
	}

	// Update is called once per frame
	public void ChangeBrightness () {
		newBrightness = brightnessSlider.value;
		RenderSettings.ambientLight = new Color(newBrightness, newBrightness, newBrightness, newBrightness);
	}
}
