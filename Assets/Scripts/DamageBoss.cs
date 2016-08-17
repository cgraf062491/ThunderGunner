using UnityEngine;
using System.Collections;

public class DamageBoss : MonoBehaviour {

	GameObject ScoreText;

	public int health;

	public int addScore;

	public AudioClip BossDead;

	bool isColliding;



	void Start(){

		ScoreText = GameObject.FindGameObjectWithTag("Score");

	}

	void OnTriggerEnter2D(Collider2D other){

		if(isColliding) return;

		isColliding = true;

		if(other.tag == "PlayerBullet"){

			health--;

			if(health < 26 && health > 19){

				gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 152, 152, 255);

			}
			if(health < 20 && health > 14){

				gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 115, 115, 255);

			}
			if(health < 15 && health > 9){

				gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 80, 80, 255);

			}
			if(health < 10 && health > 4){

				gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 80, 80, 255);

			}
			if(health < 5 && health > 0){

				gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 20, 20, 255);

			}
			
			if(health <= 0){
					
				//Die();
				StartCoroutine(Die());
			}
		}

		if(other.tag == "Changer"){
			gameObject.layer = 16;
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

		gameObject.GetComponent<AudioSource>().clip = BossDead;
		gameObject.GetComponent<AudioSource>().Play();
		ScoreText.GetComponent<ScoreScript>().PlayerScore += addScore;
		gameObject.GetComponent<SpriteRenderer>().color = Color.red;
		gameObject.layer = 10;
		yield return new WaitForSeconds(0.2f);
		Destroy(gameObject);
	}
}
