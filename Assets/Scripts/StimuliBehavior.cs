﻿using UnityEngine;
using System.Collections;

public class StimuliBehavior : MonoBehaviour {

	public bool touched = false;
	float duration = 1.0f;
	Color colorStart = Color.gray;
	Color colorEnd = Color.Lerp(Color.gray,Color.blue,0.25f);
	// Use this for initialization
	void Start () {
	
	}

	bool firstTime = true;
	float startT = 0f;
	// Update is called once per frame
	void Update () {

		if(touched)
		{
			if(firstTime){
				firstTime = false;
				startT = Time.time;
			}
			float lerp = Mathf.PingPong (Time.time-startT, duration) / duration;
			GetComponentInChildren<Renderer>().material.color = Color.Lerp (colorStart, colorEnd, lerp);
		}
	}
}
