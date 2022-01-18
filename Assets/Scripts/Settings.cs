using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {
	public Camera camera1;
	public Camera camera2;
	// Use this for initialization
	void OnMouseDown ()
	{
		camera1.enabled = false;
		camera2.enabled = true;	
	}
}
