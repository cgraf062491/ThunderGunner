using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RippleFade : MonoBehaviour {

	public Image ripple;
	public Text shadow;

	// Use this for initialization
	void Start () {

		ripple.CrossFadeAlpha(0.0f, 0.0f, false);

		shadow.CrossFadeAlpha(0.0f, 0.0f, false);

		ripple.CrossFadeAlpha(1.0f, 5f, false);

		shadow.CrossFadeAlpha(1.0f, 5f, false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
