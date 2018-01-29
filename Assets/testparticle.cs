using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testparticle : MonoBehaviour {
	float radius = 10.0f;
	// Use this for initialization
	void Start () {
		

		ParticleSystem ps = GetComponent<ParticleSystem>();
		var sh = ps.shape;
		sh.radius = radius;
	}
	
	// Update is called once per frame
	void Update () {
	}
}


