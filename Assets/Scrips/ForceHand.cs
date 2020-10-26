using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceHand : MonoBehaviour
{
	public Rigidbody rb;
	public bool doForce = false;
	public int strength1 = 700;
	public int strength2 = 650;
	private int frames =0;
	private int shift = 0;

	// Start is called before the first frame update
	void Start() {
		Debug.Log("Hello world!");
	}

	// Update is called once per frame
	void FixedUpdate() {
		if (Input.GetKey("p")){
			shift = 250;
		} else {
			shift = 0;
		}
		if (Input.GetMouseButton(0)){
			if (frames < 100){
				rb.AddForce(0, strength1 + shift, 0);
			} else {
				rb.AddForce(0, strength2 + shift, 0);
			}
		}
		frames++;
	}
}
