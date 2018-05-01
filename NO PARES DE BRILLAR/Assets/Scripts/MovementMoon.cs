using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMoon : MonoBehaviour {

    Rigidbody rb;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(new Vector3(0f,0f,1f));
	}
}
