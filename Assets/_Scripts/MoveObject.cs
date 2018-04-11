// Jamshed Ashurov 
// 04/11/2018
// This script is used to move the objects(ship for now).

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent <Rigidbody> ().velocity = new Vector3 (-4, 0, 0);
		// Moves the object on the x axis. 
	}
}
