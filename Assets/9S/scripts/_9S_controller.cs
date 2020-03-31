using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _9S_controller : MonoBehaviour {
	public float speed_scale;
	Rigidbody2D rb;
	Transform trans;
    public float hp;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		trans = GetComponent<Transform>();
	}

    public Transform getposition() {
        return transform;
    }

    public void takedmg() {
        hp -= 1;
        if (hp <= 0) {
            Destroy(gameObject);
        }

    }
	// Update is called once per frame
	void Update () {
		float H_move = Input.GetAxis("Horizontal");
		float V_move = Input.GetAxis("Vertical");
		
		rb.AddForce(new Vector2(H_move*speed_scale,0));
		rb.AddForce(new Vector2(0,V_move*speed_scale));
		
		if(H_move<0){
			Quaternion target = Quaternion.Euler(0,0,90);
			trans.rotation = Quaternion.Slerp(trans.rotation, target, Time.deltaTime * 10f);	
		}
		
		if(H_move>0){
			Quaternion target =Quaternion.Euler(0,0,-90);
			trans.rotation = Quaternion.Slerp(trans.rotation, target, Time.deltaTime * 10f);
		}
		
		if(V_move<0){
			Quaternion target = Quaternion.Euler(0,0,180);
			trans.rotation = Quaternion.Slerp(trans.rotation, target, Time.deltaTime*10f);
		}
		
		if(V_move>0){
			Quaternion target = Quaternion.Euler(0,0,0);
			trans.rotation = Quaternion.Slerp(trans.rotation, target, Time.deltaTime*10f);
		}
	}
}