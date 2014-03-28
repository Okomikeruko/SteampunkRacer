using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad(this);
	}
}
