using UnityEngine;
using System.Collections;

public class SoldierShooting : MonoBehaviour {

	public GameObject bulletPrefab;

	public GameObject bulletTwoPrefab;
	public GameObject bulletThreePrefab;

	public float fireDelay = 0.25f;

	public AudioClip SoldierLaser;

	float cooldown = 0;

	public bool powerUp;

	void Start(){

		powerUp = false;
	}
	
	// Update is called once per frame
	void Update () {

		cooldown -= Time.deltaTime;

		if(powerUp == false){

			if(Input.GetButtonDown("Fire1") && cooldown <= 0){

				PlayLaser();

				//Debug.Log("Fire Muffin!!");
				cooldown = fireDelay;

				Vector3 offset = new Vector3(0, 5f, 0);

				Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
				//Instantiate(bulletTwoPrefab, transform.position + offset, transform.rotation);
				//Instantiate(bulletThreePrefab, transform.position + offset, transform.rotation);
			}	
		}else if(powerUp == true){

			if(Input.GetButtonDown("Fire1") && cooldown <= 0){

				PlayLaser();

				//Debug.Log("Fire Muffin!!");
				cooldown = fireDelay;

				Vector3 offset = new Vector3(0, 5f, 0);

				Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
				Instantiate(bulletTwoPrefab, transform.position + offset, transform.rotation);
				Instantiate(bulletThreePrefab, transform.position + offset, transform.rotation);
			}	
		}
	}
	void PlayLaser(){

			GetComponent<AudioSource>().clip = SoldierLaser;
			GetComponent<AudioSource>().Play();
		}
}
