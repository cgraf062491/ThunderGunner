using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {

	static public Hero		S; // Singleton

	//These fields control the movement of the ship
	public float 			speed = 30;
	

	void Awake() {
		S = this;  //Set the Singleton
		//bounds = Utils.CombineBoundsOfChildren(this.gameObject);
	}

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		float x = Input.GetAxisRaw("Horizontal");
		float y = Input.GetAxisRaw("Vertical");

		Vector2 direction = new Vector2(x, y).normalized;

		Move(direction);
	
	}

	void Move(Vector2 direction){

		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));


		Vector2 pos = transform.position;

		pos += direction * speed * Time.deltaTime;

		pos.x = Mathf.Clamp(pos.x, min.x, max.x);
		pos.y = Mathf.Clamp(pos.y, min.y, max.y);

		transform.position = pos;



	}
}
