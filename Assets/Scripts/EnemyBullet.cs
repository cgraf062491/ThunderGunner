using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {

    public float speed;

    Vector2 dir;

    bool ready;

    bool isColliding;

    void Awake(){

    	ready = false;
    }

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(){

		if(isColliding) return;

		isColliding = true;

		Destroy(gameObject);

	}

	public void SetDirection(Vector2 direc){

		dir = direc.normalized;

		ready = true;
	}
	
	// Update is called once per frame
	void Update () {

		isColliding = false;

		if(ready == true){

			Vector2 pos = transform.position;

			pos += dir * speed * Time.deltaTime;

			transform.position = pos;

			Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

			Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

			if((transform.position.x < min.x) || (transform.position.x > max.x) || (transform.position.y < min.y) || (transform.position.y > max.y)){

				Destroy(gameObject);
			}
		}
	
	}

	
}
