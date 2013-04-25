using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour {
	
	int kLowestFPS=20;
	float kBpm=120.0f;
	
	float nextClock;
	public float delay;
	
	GameObject base_beat;
	//GameObject note;

	// Use this for initialization
	void Start () {
		base_beat=GameObject.FindGameObjectWithTag("Beat");
		//note=GameObject.FindGameObjectWithTag("Player");		
	}
	
	// Update is called once per frame
	void Update () {
	if(Time.time+1.0f/kLowestFPS>nextClock){
			delay=audio.clip.samples-audio.timeSamples;
			
			//print("samples"+audio.clip.samples);
			//print("timeSamples"+audio.timeSamples);
			
			base_beat.SendMessage("OnClock",delay);
			//note.SendMessage("OnClock",delay);
			nextClock+=60.0f/kBpm/4;
		}
		//print("nextClock"+nextClock);
		//print("kLowestFPS"+Time.time);
	}

}
