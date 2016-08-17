using UnityEngine;
using System.Collections;

public class DamageElite : MonoBehaviour {

	GameObject ScoreText;

	public int health;

	public int addScore;

	public AudioClip EliteDead;

	bool isColliding;



	void Start(){

		ScoreText = GameObject.FindGameObjectWithTag("Score");

	}

	void OnTriggerEnter2D(){

		if(isColliding) return;

		isColliding = true;

	
		health--;

		if(health == 1){

			gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 152, 152, 255);

		}
		
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

		gameObject.GetComponent<AudioSource>().clip = EliteDead;
		gameObject.GetComponent<AudioSource>().Play();
		ScoreText.GetComponent<ScoreScript>().PlayerScore += addScore;
		gameObject.GetComponent<SpriteRenderer>().color = Color.red;
		gameObject.layer = 10;
		yield return new WaitForSeconds(0.2f);
		Destroy(gameObject);
	}
}
