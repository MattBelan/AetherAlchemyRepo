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
		Debug.Log(musicVolumeSlider.value);
		Debug.Log(musicVolumeSlider.value);

	}

	public void GetVolume(){
		float value;
				bool result =  soundMixer.GetFloat("fxVolume", out value);
				Debug.Log(result);
				Debug.Log(value);

				// if(result){
				//
				// 		return value;
				// }else{
				// 		return 0f;
				// }
		}



	// public void ChangeVolume() {
	// 	musicMixer.SetFloat(musicVolumeSlider.value);
	// 	fxMixer.SetFloat(fxVolumeSlider.value);
	// }
}
