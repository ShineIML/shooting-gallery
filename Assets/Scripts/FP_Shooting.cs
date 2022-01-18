using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FP_Shooting : MonoBehaviour 
{
	public GameObject bullet_prefab;
	Rigidbody rb;
	float bulletImpulse = 100f;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
		{
		if (Input.GetButtonDown ("Fire1"))
		{
			Camera cam = Camera.main;
			GameObject thebullet = (GameObject)Instantiate (bullet_prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
			rb =  thebullet.GetComponent<Rigidbody> ();
			rb.AddForce( cam.transform.forward * bulletImpulse, ForceMode.Impulse);
		}
		if (Input.GetButtonDown ("Cancel"))
		{
			Screen.lockCursor = false;
			SceneManager.LoadScene ("Menu");
		}
	}
}