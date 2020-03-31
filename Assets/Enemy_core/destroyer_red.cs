using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer_red : MonoBehaviour {
    float exsisting;
	// Use this for initialization
	void Start () {
        exsisting = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (exsisting > 6.0f)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            exsisting = exsisting + 1.0f * Time.deltaTime;
        }
    }

    public void vanish() {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("walls")) { GameObject.Destroy(gameObject); }
        if (other.gameObject.CompareTag("Player")){
            _9S_controller player = other.gameObject.GetComponent<_9S_controller>();
            player.takedmg();
            Destroy(gameObject);
        }

    }
}
