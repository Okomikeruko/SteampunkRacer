using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour {

	public float volume = 50.0F;
	public float soundFX = 50.0F;

	public int Playcount = 5;

	public bool test = true;

	void Awake(){
		DontDestroyOnLoad(this);
	}
}
