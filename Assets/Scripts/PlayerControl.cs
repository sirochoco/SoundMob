using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	bool state;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Move(){
		iTween.MoveAdd(gameObject, iTween.Hash("x",2,"y",0,"time",0.5f));
	}
}
