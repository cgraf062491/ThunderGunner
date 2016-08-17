using UnityEngine;
using System.Collections;

public class MusicChange : MonoBehaviour {

	

	[SerializeField]
	private AudioClip titleMusic;

	[SerializeField]
	private AudioClip gameplayMusic;


	[SerializeField]
	private AudioSource source;


	static private MusicChange instance;
	

	// Use this for initialization
	protected virtual void Awake() {

		source = GetComponent<AudioSource>();

		if(instance == null){
			instance = this;
			DontDestroyOnLoad(this);
		}else{
			Destroy(this);
			return;
		}

		
	
	}

	protected virtual void Start() {
		//PlayMenuMusic();
	}

	static public void PlayMenuMusic(){

		if(instance != null){

			if(instance.source.clip != instance.titleMusic){
				instance.source.Stop();
				instance.source.clip = instance.titleMusic;
				instance.source.Play();
			}
		}else{
			Debug.LogError("Unavailable MusicChange component");
		}
	}

	

	static public void PlayGameMusic(){

		if(instance != null){

			if(instance.source.clip != instance.gameplayMusic){
				instance.source.Stop();
				instance.source.clip = instance.gameplayMusic;
				instance.source.Play();
				
	
			}
		}else{
			Debug.LogError("Unavailable MusicChange component");
		}

	}

	

}
