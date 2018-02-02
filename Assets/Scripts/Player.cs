using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private bool collided=true;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		move();
		
	}
	void move(){
		float Horizontal = Input.GetAxis("Horizontal")*0.1f;	
		transform.Translate(Horizontal,0,0);
		if(collided && Input.GetKey(KeyCode.Space)){
			rb.AddForce(Vector3.up*250);
		}
	}
	void OnCollisionEnter(Collision other){
		collided = true;
	} 
	void OnCollisionExit(Collision other){
		collided = false;
	} 
}
