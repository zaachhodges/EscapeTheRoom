﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour {

	public Light torch; 
	private bool isActive;

	public AudioSource audio; 
	public AudioClip lightOn;
	public AudioClip lightOff; 


	// Use this for initialization
	void Start () 
	{
		this.isActive = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if T is pressed...
		if (Input.GetKeyDown (KeyCode.T)) 
		{	//if Torch isn't active, turn on...
			if (isActive == false) {
				torch.enabled = true;
				isActive = true;

				//play audio once with PlayOneShot()
				audio.PlayOneShot(lightOn);
			}
			//if torch is already on, then turn off...
			else if (isActive == true)
			{
				torch.enabled = false;
				isActive = false;
				audio.PlayOneShot(lightOff);

			}
		}
	}
}
