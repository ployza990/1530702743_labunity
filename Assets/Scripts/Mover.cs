﻿using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{
	public int speed;
	void Start () {
		GetComponent<Rigidbody> ().velocity = transform.forward * speed;

}
	void Update() {
	}
}