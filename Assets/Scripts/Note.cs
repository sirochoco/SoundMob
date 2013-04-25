using UnityEngine;
using System.Collections;

public class Note : MonoBehaviour {
	
	public int interval;
	public int counter;
	public float beat_time;
	bool state;
	
	float param;
	
	void OnClick(){
		
	}
	
	public float BeatTime(){
		return Time.time;
	}
	
	void OnClock(ulong delay){
		if(++counter>=interval){
			if(state){	
				audio.Play();
				param=1.0f;
				
				BeatTime();
				beat_time=BeatTime();
				//print("BeatTime"+beat_time);
			}
			counter=0;
		}
	}
	// Use this for initialization
	void Start () {
		state=true;
	}
	
	// Update is called once per frame
	void Update () {
		param*=Mathf.Exp(-5.0f*Time.deltaTime);
		
		transform.localScale=Vector3.one*(1.0f+param*0.5f);
	}
}
