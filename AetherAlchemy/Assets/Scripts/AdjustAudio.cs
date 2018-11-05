using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AdjustAudio : MonoBehaviour {
	public Slider musicVolumeSlider;
	public Slider fxVolumeSlider;
	public AudioMixer soundMixer;


	void Start() {
		float fxValue;
		bool fxResult =  soundMixer.GetFloat("fxVolume", out fxValue);
		fxVolumeSlider.value = fxValue;
		float musicValue;
		bool musicResult = soundMixer.GetFloat("musicVolume", out musicValue);
		musicVolumeSlider.value = musicValue;
	}

	public void GetVolume(){
		float value;
		bool result =  soundMixer.GetFloat("fxVolume", out value);
		// Debug.Log(result);
		// Debug.Log(value);
		}

	public void ChangeVolume() {
		float value;
		soundMixer.SetFloat("musicVolume", musicVolumeSlider.value);
		soundMixer.SetFloat("fxVolume", fxVolumeSlider.value);
		// soundMixer.GetFloat("musicVolume", out value);
		// Debug.Log("musicVolume =" + value);
		// soundMixer.GetFloat("musicVolume", out value);
		// Debug.Log("fxVolume =" + value);
	}
}
