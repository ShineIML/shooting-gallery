using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back2 : MonoBehaviour {

	Renderer clr;

	void OnMouseEnter() 
	{
		clr = GetComponent<Renderer>();
		clr.material.color = Color.gray;
	}

	void OnMouseExit() 
	{
		clr = GetComponent<Renderer>();
		clr.material.color = Color.white;
	}

	void OnMouseDown ()
	{
		SceneManager.LoadScene("Menu");
	}
}
