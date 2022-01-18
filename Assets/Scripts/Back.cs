using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {

	public Camera camera1;
	public Camera camera2;
	// Use this for initialization
	void OnMouseDown ()
	{
		camera1.enabled = true;
		camera2.enabled = false;	
	}
}