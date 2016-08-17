using UnityEngine;
using System.Collections;

public class BulletDestroyer : MonoBehaviour {

	public float bulletTime = 4f;

	bool isColliding;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(){

		if(isColliding) return;

		isColliding = true;

		Destroy(gameObject);

	}
	
	// Update is called once per frame
	void Update () {

		isColliding = false;

		bulletTime -= Time.deltaTime;

		if(bulletTime <= 0){

			Destroy(gameObject);

		}
	
	}
}
