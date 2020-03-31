using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour {
    public Transform player;
    public Transform boundry_upper;
    public Transform boundry_down;
    public Transform boundry_left;
    public Transform boundry_right;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player != null) {
            if (player.position.x < boundry_right.position.x && player.position.x> boundry_left.position.x) {
                transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
            }

            if (player.position.y < boundry_upper.position.y && player.position.y > boundry_down.position.y) {
                transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
            }
            

        }
	}
}
