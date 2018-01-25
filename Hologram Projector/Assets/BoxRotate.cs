using UnityEngine;
using System.Collections;
using System;


public class BoxRotate : MonoBehaviour {

	float mouseScalar = 100.0f;
	float halfScreen = Screen.width/2.0f;
	float panFactor = 10.0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
        //this.transform.Rotate(new Vector3(0, 1));
		if (Input.mousePresent && Input.GetMouseButton (0)) {
			this.transform.Rotate ((new Vector3 (Input.mousePosition.x - halfScreen, Input.mousePosition.y - halfScreen, 0.0f)) / mouseScalar);
		} else if (Input.GetJoystickNames().Length > 0 && (Input.GetAxis("Vertical") != 0.0f || Input.GetAxis("Horizontal") != 0)) {
			this.transform.Rotate (new Vector3 (Input.GetAxis ("Vertical"), Input.GetAxis ("Horizontal"), 0));
		} else {
			//Rotate fancily
			this.transform.Rotate(new Vector3(0, 0.5f));
			//orbit back to 0,0,0
//			float tmpx = (Math.Abs(this.transform.rotation.x) < panFactor ? 0.0f : (this.transform.rotation.x < 0 ? this.transform.rotation.x + panFactor : this.transform.rotation.x - panFactor));
//			float tmpz = (Math.Abs(this.transform.rotation.z) < panFactor ? 0.0f : (this.transform.rotation.z < 0 ? this.transform.rotation.z + panFactor : this.transform.rotation.z - panFactor));
//			this.transform.rotation.Set (tmpx, this.transform.rotation.y, tmpz, this.transform.rotation.w);
		}
	}
		

}
