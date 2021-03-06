using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	//How to actually play audio:
	//In the code you want the audio to play then write the following line:
	//FindObjectOfType<AudioManager>().Play("NameOfTheClip");
	//FindObjectOfType<AudioManager>().StopPlaying("sound string name");
	public static AudioManager instance;

	public AudioMixerGroup mixerGroup;

	public Sound[] sounds;

	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.loop;

			s.source.outputAudioMixerGroup = mixerGroup;
		}

		/*if (Application.loadedLevelName == "MainMenu")
		{
			FindObjectOfType<AudioManager>().StopPlaying("LevelMusic");
			FindObjectOfType<AudioManager>().Play("MenuMusic");
		}

		else if (Application.loadedLevelName == "Level1")
		{
			FindObjectOfType<AudioManager>().StopPlaying("MenuMusic");
			FindObjectOfType<AudioManager>().Play("LevelMusic");
		}

		else if (Application.loadedLevelName == "End")
		{
			FindObjectOfType<AudioManager>().StopPlaying("LevelMusic");
			FindObjectOfType<AudioManager>().Play("MenuMusic");
		}*/
	}

	public void Play(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

		s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
		s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

		s.source.Play();
	}

	public void StopPlaying(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

		s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
		s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

		s.source.Stop();
	}

    //For when you want to destroy the audio manager in a scene and start playing different music
    /* void Update()
     {
         if (Application.loadedLevelName == "Level1")
         {
             Destroy(this.gameObject);
         }
     }*/

   /* void Start()
    {
		if (Application.loadedLevelName == "MainMenu")
        {
			FindObjectOfType<AudioManager>().Play("MenuMusic");
		}

		else if (Application.loadedLevelName == "Level1")
        {
			FindObjectOfType<AudioManager>().Play("LevelMusic");
		}
    }*/
}
