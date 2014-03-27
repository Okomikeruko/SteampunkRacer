using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour {

	void Start()
	{

	}
	
	void OnGUI()
	{
		Rect[] buttons = new Rect[4];
		
		for (int i = 0; i < 4; i++)
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
		GUI.Label (new Rect((Screen.width/2)-200, (Screen.height/2)-300, 400, 100), "Running On Empty", Title);
		
//		GameObject playerRef = GameObject.Find ("Player Info");
//		PlayerInfoBehavior playerCode = playerRef.GetComponent<PlayerInfoBehavior>();
		
		if(GUI.Button (buttons[0], "Play Games"))
		{
//			this.gameObject.AddComponent<PlayMenuGUI>();
//			Destroy(this);
		}

		if(GUI.Button (buttons[1], "Change Player"))
		{
//			this.gameObject.AddComponent<PlayerMenuGUI>();
//			Destroy(this);
		}
		
		if(GUI.Button (buttons[2], "Settings"))
		{
//			Debug.Log("Load the Settings");
//			Destroy(this);
		}

		if(GUI.Button (buttons[3], "Quit"))
		{
//			playerCode.SaveData();
			Application.Quit();
		}
	}
}
