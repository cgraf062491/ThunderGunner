using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	Text scoreWords;

	int playerScore;

	public int PlayerScore
	{
		get
		{
			return this.playerScore;
		}
		set
		{
			this.playerScore = value;
			UpdateScore();
		}
	}


	// Use this for initialization
	void Start () {

		scoreWords = GetComponent<Text>();
	
	}

	void OnDisable(){

		PlayerPrefs.SetInt("Score", (int)playerScore);
	}
	
	// Update is called once per frame
	void UpdateScore () {

		string scoreString = string.Format("{0:00000000}", playerScore);
		scoreWords.text = scoreString;
	
	}


	


}
