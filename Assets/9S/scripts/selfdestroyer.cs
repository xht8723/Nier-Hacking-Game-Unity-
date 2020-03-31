using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdestroyer : MonoBehaviour {
    float exsisting;
	// Use this for initialization
	void Start () {
        exsisting = 0f;
	}


    // Update is called once per frame
    void Update () {
        if (exsisting > 4.0f)
        {
            GameObject.Destroy(gameObject);
        }
        else {
            exsisting = exsisting + 1.0f*Time.deltaTime;
        }
	}

    void OnTriggerEnter2D(Collider2D other) {
        if(!other.gameObject.CompareTag("Player") && !other.gameObject.CompareTag("dark_bullets") && !other.gameObject.CompareTag("bullets"))GameObject.Destroy(gameObject);
        if (other.gameObject.CompareTag("shootable")) {

            try { Core_controller enemy = other.gameObject.GetComponent<Core_controller>();
                enemy.takedmg();
            }
            catch(System.NullReferenceException ex){
                Minion_1_controller minion = other.gameObject.GetComponent<Minion_1_controller>();
                minion.takedmg();
            }
           
        }

        if (other.gameObject.CompareTag("red_bullets")) {
            destroyer_red bullets = other.gameObject.GetComponent<destroyer_red>();
            bullets.vanish();
            Destroy(gameObject);
        }

    }
}
