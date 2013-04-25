using UnityEngine;
using System.Collections;

public class BaseBeat : MonoBehaviour {
	
	public int interval;
	public int counter;
	public float beat_time;
	
	public Clock m_Clock;

	// Use this for initialization
	void Start () {
		m_Clock=GameObject.Find("Clock").GetComponent<Clock>();
	}
	
	void OnClock(float delay){
		if(++counter>=interval){
			float d=delay/44100;
			//audio.PlayDelayed(d);
			audio.Play();
				
			BeatTime();
			beat_time=BeatTime();
				
			counter=0;
		}
	}
	// Update is called once per frame
	void Update () {

	}
	
	public float BeatTime(){
		return Time.time;
	}
}
