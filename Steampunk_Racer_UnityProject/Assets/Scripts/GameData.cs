using UnityEngine;
using System;
using System.Collections;

public class GameData : MonoBehaviour {

	public float volume = 50.0F;
	public float soundFX = 50.0F;

	public int Playcount = 5;

	private string[] collectableType;
	private int[] collectableValue;

	void Awake(){
		DontDestroyOnLoad(this);
		Application.LoadLevel ("menus");

		collectableType = Enum.GetNames(typeof(Collectable.typename));
		collectableValue = new int[3];
	}

	public void collect(Collectable.typename type, int value)
	{
		for(int i = 0; i < collectableValue.Length; i++)
		{
			if (collectableType[i] == type.ToString())
			{
				collectableValue[i] += value;
				Debug.Log (collectableValue[i].ToString());
			}
		}
	}
}
