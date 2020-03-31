using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {
    public Transform shotspawn;
    public GameObject bullets;
    public float firerate;
    float nextfire;
	// Use this for initialization
	void Start () {
        nextfire = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Space) && Time.time>nextfire){
            nextfire = Time.time + firerate;
            GameObject bullet = Instantiate(bullets,shotspawn.position,shotspawn.rotation) as GameObject;
            bullet.GetComponent<Rigidbody2D>().AddForce(transform.up*1500);
        }
	}
}
