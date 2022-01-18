using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour {

	void OnMouseDown ()
	{
		SceneManager.LoadScene("author");
	}
}