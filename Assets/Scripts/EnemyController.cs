using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float speedY = 10f;
	//public float speedX = 5f;
	//public float speedXX = 7f;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 pos = transform.position;

		pos = new Vector2 (pos.x, pos.y - speedY * Time.deltaTime);


		transform.position = pos;

		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2 (0,0));

		if(transform.position.y < min.y){

			Destroy(gameObject);
		}

	}

}
