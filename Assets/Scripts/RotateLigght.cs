using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLigght : MonoBehaviour {
	public float speedo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward*speedo,Space.World);
	}
}
