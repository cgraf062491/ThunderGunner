using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {

	Vector3 endSpot;
	Vector3 startSpot;

	float almost;

	// Use this for initialization
	void Start () {


		startSpot = transform.position;
		endSpot = transform.position + new Vector3(0, -65, 0);

		
	
	}
	
	// Update is called once per frame
	void Update() {

		almost += 0.005f;
		transform.position = Vector3.Lerp(startSpot, endSpot, almost);
		
	}
}
