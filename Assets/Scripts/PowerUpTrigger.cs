using UnityEngine;
using System.Collections;

public class PowerUpTrigger : MonoBehaviour {

	bool isColliding;

	public AudioClip Powered;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(){
		if(isColliding) return;

		isColliding = true;

		StartCoroutine(Contact());
	}
	
	// Update is called once per frame
	void Update () {

		isColliding = false;
	
	}

	IEnumerator Contact(){
		GetComponent<AudioSource>().clip = Powered;
		GetComponent<AudioSource>().Play();
		gameObject.GetComponent<SpriteRenderer>().color = Color.clear;
		gameObject.layer = 10;
		yield return new WaitForSeconds(1f);
		Destroy(gameObject);
	}
}
