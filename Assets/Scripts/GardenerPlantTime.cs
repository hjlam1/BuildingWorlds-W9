using UnityEngine;
using System.Collections;

public class GardenerPlantTime : MonoBehaviour {

	public GameObject tree;
	public float plantRate = 5f;
	private float nextPlant = 2f;
	public float plantHeight = 5f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextPlant) {
			float turnAngle = Random.Range (0, 359);
			Quaternion rotation = Quaternion.identity;

			nextPlant = Time.time + plantRate;

			this.transform.eulerAngles = new Vector3(0f,turnAngle,0f);

			rotation.eulerAngles = new Vector3(0,turnAngle,0);
			Instantiate (tree, new Vector3(this.transform.position.x, this.transform.position.y + plantHeight, this.transform.position.z), rotation);

		}
	}
}
