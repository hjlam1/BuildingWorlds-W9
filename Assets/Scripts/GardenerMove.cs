using UnityEngine;
using System.Collections;

public class GardenerMove : MonoBehaviour {

	// Use this for initialization
	private float turnAngle;
	public int topSpeed=50;

	void Start () {
		turnAngle = Random.Range (0, 359);
		this.transform.eulerAngles = new Vector3(0f,turnAngle,0f);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 forward = transform.TransformDirection (Vector3.forward);
		rigidbody.AddForce (forward * Time.deltaTime * topSpeed);
		if (Physics.Raycast (this.transform.position, forward, 3f)) {
			turnAngle = Random.Range (90, 270);
			this.transform.eulerAngles = new Vector3(0f,turnAngle,0f);
		}

	}
}
