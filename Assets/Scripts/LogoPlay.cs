using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LogoPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Invoke("NextScene", 6);
	
	}
	
	void NextScene(){

		SceneManager.LoadScene(1);
	}
}
