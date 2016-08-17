using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	GameObject ScoreText;

	public int health;

	public int addScore;

	public AudioClip StormbringerDead;

	bool isColliding;



	void Start(){

		ScoreText = GameObject.FindGameObjectWithTag("Score");

	}

	void OnTriggerEnter2D(){

		if(isColliding) return;

		isColliding = true;

	
		health--;
		
		if(health <= 0){
				
			//Die();
			StartCoroutine(Die());
		}
		
	}

	void Update(){

		isColliding = false;


		
	}

	/*void Die(){

		ScoreText.GetComponent<ScoreScript>().PlayerScore += addScore;
		Destroy(gameObject);
		
	}*/

	IEnumerator Die(){

		gameObject.GetComponent<AudioSource>().clip = StormbringerDead;
		gameObject.GetComponent<AudioSource>().Play();
		ScoreText.GetComponent<ScoreScript>().PlayerScore += addScore;
		gameObject.GetComponent<SpriteRenderer>().color = Color.red;
		gameObject.layer = 10;
		yield return new WaitForSeconds(0.2f);
		Destroy(gameObject);
	}

	
}
