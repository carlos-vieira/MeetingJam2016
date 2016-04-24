using UnityEngine;
using System.Collections;

namespace AssemblyCSharp {
	public class Scroll : MonoBehaviour {

		public Rigidbody rb;
		public float speed = 0.5f;

		// Use this for initialization
		void Start () {
			rb = GetComponent<Rigidbody>();
		}
		
		// Update is called once per frame
		void FixedUpdate () {
			if (rb.transform.position.x > -8) {
				Vector3 p = rb.transform.position;
				p.x -= this.speed;
				rb.transform.position = p;
			}
			if (rb.transform.position.x < -5) {
				if (Random.Range(0, 100) > 97) {
					Vector3 p = rb.transform.position;
					p.x = 8;
					rb.transform.position = p;
				}
			}
		}
	}
}