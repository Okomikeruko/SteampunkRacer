using UnityEngine;
using System.Collections;

public class StatsGUI : MonoBehaviour {

	GameData Data;
	private GUIStyle Title = new GUIStyle();
	private Rect[] buttons = new Rect[2];
	private string[] buttonName = new string[2];
	
	void Start()
	{
//		Data = GameObject.Find ("Data").GetComponent<GameData>();
		
		Title.fontSize = 45;
		Title.alignment = TextAnchor.MiddleCenter;
		Title.normal.textColor = Color.white;

		buttonName = new string[] {"Replay", "Main Menu"};

		for(int i = 0; i < 2; i++)
		{
			buttons[i] = new Rect(((Screen.width-80)/2)-100+(200*i),(Screen.height-50)/2,80,50);
		}
	}

	void OnGUI()
	{
		GUI.Label (new Rect((Screen.width/2)-200, (Screen.height/2)-200, 400, 100), "Game Over", Title);
		
		for(int i = 0; i < 2; i++)
		{
			if(GUI.Button (buttons[i], buttonName[i]))
			{
				if(buttonName[i] == "Replay")
				{
					Application.LoadLevel("game");
				}
				
				if(buttonName[i] == "Main Menu")
				{
					Application.LoadLevel("menus");
				}
			}
		}
	}
}
