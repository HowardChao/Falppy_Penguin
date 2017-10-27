using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;

public class RepeatingBackground : MonoBehaviour {

	private BoxCollider2D groundCollider;
	private float groundHorizontalLength;	// store the length
	// Use this for initialization
	void Start () {
		groundCollider = GetComponent <BoxCollider2D> ();
		groundHorizontalLength = groundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -groundHorizontalLength) {
			ReadPositionBackground ();
		}
	}

	private void ReadPositionBackground(){
		Vector2 groundOffset = new Vector2(17.21f*2f, 0);
		transform.position = (Vector2) transform.position + groundOffset;
	}
}
