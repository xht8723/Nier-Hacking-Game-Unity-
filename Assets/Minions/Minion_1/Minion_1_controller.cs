using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion_1_controller : MonoBehaviour {
    public GameObject projectile;
    public float firerate;
    float nextfire;
    float hp;
	// Use this for initialization
	void Start () {
        nextfire = 0;
        hp = 1;
	}

    public void takedmg() {
        hp = hp - 1;
        if (hp <= 0) {
            Destroy(gameObject);
        }
    }

	// Update is called once per frame
	void Update () {
        if (Time.time > nextfire)
        {
            GameObject trans = GameObject.Find("9S");
            nextfire = Time.time + firerate;
            Vector2 direction = trans.transform.position - transform.position;
            GameObject bullet = Instantiate(projectile,transform.position,transform.rotation) as GameObject;
            bullet.GetComponent<Rigidbody2D>().AddForce(direction.normalized*700);
        }
	}
}
