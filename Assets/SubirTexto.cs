using UnityEngine;
using System.Collections;

public class SubirTexto : MonoBehaviour {

	private Rigidbody2D rd;
	private float A = 10;

	// Use this for initialization
	void Start () {
		rd = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rd.velocity = new Vector2(0, A);
	}
}
