using UnityEngine;
using System.Collections;

public class HeadRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;//Gyro used to sense the head rotation in the device
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion att = Input.gyro.attitude;//This gets the attitude of the device which is rotation from Gyro
		//This rotation is not oriented with our head, so we need to rotate the rotation so that matches with the head movements
		att = Quaternion.Euler (90f, 0f, 0f) * new Quaternion (att.x, att.y, -att.z, -att.w);
		transform.rotation = att;

	}
}
