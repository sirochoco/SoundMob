using UnityEngine;
using System.Collections;

public class Clicker : MonoBehaviour {
	//GameObject base_beat;
	GameObject note;
	Note m_baseBeat;
	
	float click_time;

	// Use this for initialization
	void Start () {
		
		m_baseBeat=GameObject.Find("BaseBeat").GetComponent<Note>();
		note=GameObject.FindGameObjectWithTag("Player");
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			ClickTime();
			click_time=ClickTime();
			CheckTiming();
			}
	}
		void CheckTiming(){
		float margin=m_baseBeat.beat_time-click_time;
		print("margin"+margin);
	}
	
	float ClickTime(){
		return Time.time;
	}
	
}
