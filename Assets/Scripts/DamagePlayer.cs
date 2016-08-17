using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DamagePlayer : MonoBehaviour {

	public int health = 10;

	public Image healthbar;

	public AudioClip hit;



	bool isColliding;


	int startLayer;


	void Start(){

		startLayer = gameObject.layer;

	}


	void OnTriggerEnter2D(Collider2D other){

		if(isColliding) return;

		isColliding = true;


		if(other.tag == "Enemy" || other.tag == "Boss"){

			if(health > 1){

				GetComponent<AudioSource>().clip = hit;
				GetComponent<AudioSource>().Play();

			}
			
			GetComponent<SoldierShooting>().powerUp = false;
			health = health - 1;
			healthbar.fillAmount -= 0.1f;


			StartCoroutine(Flash());


			if(health <= 0){
				Die();
			}
		}else if(other.tag == "Up"){
			GetComponent<SoldierShooting>().powerUp = true;
		}

		
	}

	void Update(){

		isColliding = false;


	}

	void Die(){

		Destroy(gameObject);
	}

	IEnumerator Flash(){

		gameObject.layer = 14;
		GetComponent<Renderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = false;
		yield  return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = false;
		yield  return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = false;
		yield  return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds(.3f);
		gameObject.layer = startLayer;
		

	}
}
