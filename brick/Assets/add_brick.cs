using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Impinj.OctaneSdk;

public class add_brick : MonoBehaviour {
	// Use this for initialization
	void Start () {
		// init bricks
		ImpinjReader reader = new ImpinjReader();
		var cube2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube2.AddComponent<Rigidbody> ();
		cube2.transform.position = new Vector3 (0, 5, 3);
		try
		{
			reader.Connect("SpeedwayR-10-25-32");

			Settings settings = reader.QueryDefaultSettings();

			// Enable all of the antenna ports.
			settings.Antennas.EnableAll();

			// Apply the newly modified settings.
			reader.ApplySettings(settings);

			// Assign event handlers for GPI and antenna events.
//			reader.GpiChanged += OnGpiEvent;
//			reader.AntennaChanged += OnAntennaEvent;

			// Start the reader (required for antenna events).
			reader.Start();

			// Wait for the user to press enter.
			print("Press enter to exit.");
			Console.ReadLine();

			// Stop reading.
			reader.Stop();

			// Disconnect from the reader.
			reader.Disconnect();

		}
		catch (OctaneSdkException e)
		{
			// Handle Octane SDK errors.
			print( e.Message);
			print ("oct");
		}
		catch (Exception e)
		{
			// Handle other .NET errors.
			print ("net");
			print( e.Message);
			print ("net");
		}
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
