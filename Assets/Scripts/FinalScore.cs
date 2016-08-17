using UnityEngine;
using System.Collections;

public class FinalScore : MonoBehaviour {

int score = 0;

	GUIStyle guiStyle = new GUIStyle();

	// Use this for initialization
	void Start () {

		score = PlayerPrefs.GetInt("Score");
	}
	
	void OnGUI(){

		guiStyle.fontSize = 40;
		guiStyle.normal.textColor = Color.yellow;
		GUI.Label(new Rect(Screen.width/ 2 - 100, 100, 80, 100), "Score: " + score, guiStyle);
	}
}
