using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		move();
	}
	void move(){
		float dir = Input.GetAxis("Horizontal");
		Vector3 pos = transform.position;
		pos.x += dir*50;
		transform.position = pos;
		print(pos);
	}
}
