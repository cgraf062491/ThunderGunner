using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pause : MonoBehaviour {

	public bool pausible;

	public Text pauseText;

	// Use this for initialization
	void Start () {

		pausible = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("p")) {
			
			if(pausible == true){

				Time.timeScale = 0;
				pausible = false;
				pauseText.enabled = true;
			}
			else{

				Time.timeScale = 1;
				pausible = true;
				pauseText.enabled = false;
			}
		}
	}
}
