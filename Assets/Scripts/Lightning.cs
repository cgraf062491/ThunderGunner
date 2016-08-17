using UnityEngine;
using System.Collections;

public class Lightning : MonoBehaviour {

	public float 		minTime = 0.5f;
	public float 		threshhold = 0.5f;

	public GameObject 	myLight;

	private float 		lastTime = 0;

	[SerializeField]
	public AudioClip[] thunderClip;


	// Use this for initialization
	void Start () {

		
	
	}
	
	// Update is called once per frame
	void Update () {

		if((Time.time - lastTime) > minTime){
			if(Random.value > threshhold){

				GetComponent<Light>().enabled = true;
				PlayClips();

			}else{
				GetComponent<Light>().enabled = false;
			}

		lastTime = Time.time;

		}

	}

	void PlayClips() {

		GetComponent<AudioSource>().clip = thunderClip[Random.Range(0, 5)];
		GetComponent<AudioSource>().Play();
	
	}
}
