using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Core_controller : MonoBehaviour {
    public float hp;
    public Transform trans0;
    public Transform trans1;
    public GameObject[] projectile;
    public float firerate;
    public float nextfire;
    public Transform player;
    private float time;
    public float movetoward;
    public GameObject spawncontroller;
    private Spawn_controller spawn_controller;
	// Use this for initialization
	void Start () {
        spawn_controller = spawncontroller.GetComponent<Spawn_controller>();
	}

    // Update is called once per frame
    public void dead() {
        spawn_controller.killcore();
    }

    public void takedmg()
    {
        hp -= 25;
        if (hp <= 0) dead();
    }

	void Update () {
        if (Time.time > nextfire) {
            nextfire = Time.time + firerate;
            int ran = Random.Range(0, 2);
            int ran2 = Random.Range(0, 2);
            GameObject bullet0 = Instantiate(projectile[ran], trans0.position, trans0.rotation) as GameObject;
            GameObject bullet1 = Instantiate(projectile[ran2], trans1.position, trans1.rotation) as GameObject;

            bullet0.GetComponent<Rigidbody2D>().AddForce(-trans0.up * 450);
            bullet1.GetComponent<Rigidbody2D>().AddForce(trans1.up * 450);
        }


        if (player != null) {
            Vector2 direction = Vector2.MoveTowards(transform.position, player.position, movetoward);
            if (time >= 3f)
            {
                movetoward = -movetoward;
                time = 0f;
            }
            else {
                time += 1f * Time.deltaTime;
            }
            transform.position = direction;
        } 


    }
}
