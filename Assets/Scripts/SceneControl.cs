using UnityEngine;
using System.Collections;

public class SceneControl : MonoBehaviour {
	
	public float SET_MARGIN_MAX;
	public float SET_MARGIN_MIM;
	
	GameObject player;
	
	public Clock m_Clock;
	public BaseBeat m_BaseBeat;
	public float click_time;
	float margin;
	
	public bool timingGood;

	// Use this for initialization
	void Start () {
		player=GameObject.FindGameObjectWithTag("Player");
		
		m_Clock=GameObject.Find("Clock").GetComponent<Clock>();
		m_BaseBeat=GameObject.Find("BaseBeat").GetComponent<BaseBeat>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			ClickTime();
			click_time=ClickTime();
			
			CheckTiming();
			
			if(timingGood){
				player.SendMessage("Move");
				timingGood=false;
			}

			print("margin"+margin);
		}
		
		
	}
	
	public float ClickTime(){
		return Time.time;
	}
	
	void CheckTiming(){
		margin=click_time-m_BaseBeat.beat_time;
		//margin=Mathf.Abs(click_time-m_BaseBeat.beat_time);
		if(margin<SET_MARGIN_MAX){
			if(margin>SET_MARGIN_MIM){
				timingGood=true;
			}
	
		}
	}
}
