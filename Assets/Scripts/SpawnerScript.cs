using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	public GameObject Stormbringer;
	public GameObject StormbringerElite;
	public GameObject PowerUp;

	public float spawnRate = 2.9f;
	public float spawnRateElite = 2.9f;



	// Use this for initialization
	void Start () {

		Invoke("Spawn", spawnRate);

		InvokeRepeating("SpawnPowerUp", 35f, 20f);

		StartCoroutine(Delay());

		

		InvokeRepeating("SpawnRateIncrease", 10f, 7f);

		InvokeRepeating("SpawnRateIncreaseElite", 30f, 7f);
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void Spawn(){

		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

		GameObject Enemay = (GameObject)Instantiate (Stormbringer);
		Enemay.transform.position = new Vector2 (Random.Range (min.x + 10f, max.x - 10f), max.y);

		NextSpawn();
	}

	void SpawnElite(){

		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

		GameObject Enemay = (GameObject)Instantiate (StormbringerElite);
		Enemay.transform.position = new Vector2 (Random.Range (min.x + 10f, max.x - 10f), max.y);

		NextSpawnElite();
	}

	void SpawnPowerUp(){

		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

		GameObject Up = (GameObject)Instantiate (PowerUp);
		Up.transform.position = new Vector2 (Random.Range (min.x + 10f, max.x - 10f), max.y);


	}


	void NextSpawn(){

		Invoke("Spawn", spawnRate);
	}

	void NextSpawnElite(){

		Invoke("SpawnElite", spawnRate);
	}

	void SpawnRateIncrease(){
		if(spawnRate >= 0.9f){

			spawnRate -= 0.2f;
		}

		if(spawnRate == 0.9f){
			CancelInvoke("SpawnRateIncrease");
		}
		
	}
	void SpawnRateIncreaseElite(){
		if(spawnRateElite >= 1.5f){

			spawnRateElite -= 0.2f;
		}

		if(spawnRateElite == 1.5f){
			CancelInvoke("SpawnRateIncreaseElite");
		}
		
	}

	IEnumerator Delay(){

		yield return new WaitForSeconds(30f);
		Invoke("SpawnElite", spawnRateElite);

		

	}
}
