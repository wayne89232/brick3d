using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init_brick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// init bricks


	}
	
	// Update is called once per frame
	void Update () {
		// if keys pressed
		if (Input.GetKeyDown ("space")) {
			var cube2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube2.AddComponent<Rigidbody> ();
			cube2.transform.position = new Vector3 (0, 5, 3);
		} else if (Input.GetKeyDown (KeyCode.Alpha1)) {
			var cube2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube2.AddComponent<Rigidbody> ();
			cube2.transform.position = new Vector3 (-1, 5, 4);			
		}else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			var cube2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube2.AddComponent<Rigidbody> ();
			cube2.transform.position = new Vector3 (0, 5, 4);			
		}else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			var cube2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube2.AddComponent<Rigidbody> ();
			cube2.transform.position = new Vector3 (1, 5, 4);			
		}else if (Input.GetKeyDown (KeyCode.Alpha4)) {
			var cube2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube2.AddComponent<Rigidbody> ();
			cube2.transform.position = new Vector3 (-1, 5, 3);			
		}else if (Input.GetKeyDown (KeyCode.Alpha5)) {
			var cube2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube2.AddComponent<Rigidbody> ();
			cube2.transform.position = new Vector3 (0, 5, 3);			
		}
	}
}
