using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {

	public GameObject EnemyBullet;

	public AudioClip EnemyLaser;

	// Use this for initialization
	void Start () {

		InvokeRepeating("Fire", 0.3f, 2f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Fire(){

		GameObject SoldierShip = GameObject.Find("SoldierShip");

		if(SoldierShip != null){

			GameObject bullet = (GameObject)Instantiate(EnemyBullet);

			bullet.transform.position = transform.position;

			Vector2 dir = SoldierShip.transform.position - bullet.transform.position;

			bullet.GetComponent<EnemyBullet>().SetDirection(dir);

			PlayLaser();
		}
	}

	void PlayLaser(){

		GetComponent<AudioSource>().clip = EnemyLaser;
		GetComponent<AudioSource>().Play();
	}
}
