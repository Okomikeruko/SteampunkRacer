using UnityEngine;
using System.Collections;

public class StatsMenuGUI : MonoBehaviour {

	public int Playcount = 5;
	public Rect windowRect = new Rect(20, 20, 120, 50);

	void OnGUI(){

		Rect[] buttons = new Rect[3];
		
		for (int i = 0; i < 3; i++)
		{
			int w = 120;
			int h = 40;
			int o = 12;
			int x = Screen.width;
			int y = Screen.height;
			
			buttons[i] = new Rect((x-w)/2, ((y-((3*o)+(4*h)))/2)+((h+o)*i), w, h);
		}

		GUIStyle Title = new GUIStyle();
		Title.fontSize = 45;
		Title.alignment = TextAnchor.MiddleCenter;
		Title.normal.textColor = Color.white;
		GUI.Label (new Rect((Screen.width/2)-200, (Screen.height/2)-200, 400, 100), "Stats", Title);

		GUI.Label (buttons[0], "Stats: You have played " + Playcount + " times.");
		
		if(GUI.Button (buttons[1], "Reset Stats"))
		{

//			this.gameObject.AddComponent<MainMenuGUI>();
			Playcount = 0;
		}
		
		if(GUI.Button (buttons[2], "Main Menu"))
		{
			this.gameObject.AddComponent<MainMenuGUI>();
			Destroy(this);
		}
	}
}
