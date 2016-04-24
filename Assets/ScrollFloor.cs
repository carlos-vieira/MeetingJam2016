using UnityEngine;
using System.Collections;

public class ScrollFloor : MonoBehaviour {

	public Rigidbody rb;
	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 p = rb.transform.position;
		p.x -= this.speed;
		rb.transform.position = p;
		if (rb.transform.position.x < -15) {
			p.x = 15;
			rb.transform.position = p;
		}
	}
}
