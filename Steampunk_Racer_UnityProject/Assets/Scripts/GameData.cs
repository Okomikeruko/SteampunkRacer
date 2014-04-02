using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour {

	public float volume = 50.0F;
	public float soundFX = 50.0F;

	public int Playcount = 5;

	// This is an unnessary variable. We're not using it.
	public bool test = true;

	void Awake(){
		DontDestroyOnLoad(this);
		Application.LoadLevel ("menus");
	}
}
