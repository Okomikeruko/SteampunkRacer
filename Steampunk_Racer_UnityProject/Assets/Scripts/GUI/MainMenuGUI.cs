﻿using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour {
	
	Rect[] buttons = new Rect[3];


	[SerializeField]
	private string Game;
	[SerializeField]
	private string GameTitle;
	[SerializeField]
	private GUIStyle TitleStyle;

	void Start()
	{
		for (int i = 0; i < 3; i++)
		{
			int w = 120;
			int h = 40;
			int o = 12;
			int x = Screen.width;
			int y = Screen.height;
			
			buttons[i] = new Rect((x-w)/2, ((y-((3*o)+(4*h)))/2)+((h+o)*i), w, h);
		}
	}

	void OnGUI()
	{
		GUI.Label (new Rect((Screen.width/2)-200, (Screen.height/2)-200, 400, 100), GameTitle, TitleStyle);

		if(GUI.Button (buttons[0], "Play Now"))
		{
			Application.LoadLevel (Game);
		}

		if(GUI.Button (buttons[1], "Stats"))
		{
			this.gameObject.AddComponent<StatsMenuGUI>();
			this.enabled = false;
		}
		
		if(GUI.Button (buttons[2], "Options"))
		{
			this.gameObject.AddComponent<OptionsMenuGUI>();
			this.enabled = false;
		}
	}
}
