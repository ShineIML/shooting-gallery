using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_ThermalDetonator : MonoBehaviour {

	float lifespan = 3.0f;
	public GameObject fireEffect;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		lifespan -= Time.deltaTime;

		if(lifespan <= 0) {
			Explode();
		}
	}

	void OnCollisionEnter(Collision collision) {

		if(collision.gameObject.tag == "Enemy") {
			collision.gameObject.tag = "Untagged";
			Instantiate(fireEffect, collision.transform.position, Quaternion.identity);
			Destroy(gameObject);			
		}
	}

	void Explode() {

		Destroy(gameObject);
	}
}