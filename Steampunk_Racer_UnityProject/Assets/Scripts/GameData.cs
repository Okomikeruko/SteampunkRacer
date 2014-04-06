using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour {

	public float volume = 50.0F;
	public float soundFX = 50.0F;

	public int Playcount = 5;

	private string[] collectableType;
	private int[] collectableValue;

	// This is an unnessary variable. We're not using it.
	public bool test = true;

	void Awake(){
		DontDestroyOnLoad(this);
		Application.LoadLevel ("menus");

		collectableType = new string[] {"Coin"};
		collectableValue = new int[collectableType.Length];
	}

	public void collect(string type, int value)
	{
		for(int i = 0; i < collectableValue.Length; i++)
		{
			if (collectableType[i] == type)
			{
				collectableValue[i] += value;
				Debug.Log (collectableValue[i].ToString());
			}
		}
	}
}
