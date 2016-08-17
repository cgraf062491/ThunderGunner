using UnityEngine;
using System.Collections;

public class BossSpawn : MonoBehaviour {

	public GameObject StormbringerBoss;



	// Use this for initialization
	void Start () {

		Invoke("SpawnBoss", 60f);
	
	}

	
	void SpawnBoss(){	

		GameObject bigBoss = (GameObject)Instantiate(StormbringerBoss);
		bigBoss.transform.position = new Vector2(0, 87);

		StartCoroutine(BossDelay());
	}

	IEnumerator BossDelay(){

		while(GameObject.FindWithTag("Boss") != null){

			yield return new WaitForSeconds(5f);
		}

		Invoke("SpawnBoss", 60f);
	}

	
}
