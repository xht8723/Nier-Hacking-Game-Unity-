using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilerotation : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(gameObject.transform.parent.position, transform.forward, 3.5f);


	}
}
