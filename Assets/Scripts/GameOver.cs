using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	bool playOnce = false;

	public AudioClip death;


	// Use this for initialization
	void Start () {

		
	
	}
	
	// Update is called once per frame
	void Update () {

		GameObject SoldierShip = GameObject.Find("SoldierShip");

		if(SoldierShip == null && !playOnce){

			StartCoroutine(Death());
			playOnce = true;
		}

	
	}

	IEnumerator Death(){

		GetComponent<AudioSource>().clip = death;
		GetComponent<AudioSource>().Play();


		yield return new WaitForSeconds(4f);

		SceneManager.LoadScene(5);



	}
}
