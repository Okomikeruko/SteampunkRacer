using UnityEngine;
using System.Collections;

public class OptionsMenuGUI : MonoBehaviour {

	private GameData data;

	void Start(){
		data = GameObject.Find ("Data").GetComponent<GameData>();
	}

	void OnGUI () {
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
		GUI.Label (new Rect((Screen.width/2)-200, (Screen.height/2)-200, 400, 100), "Options", Title);
		
// 		Volume Control
		data.volume = GUI.HorizontalSlider(buttons[0], data.volume, 0.0F, 100.0F);
		GUI.Label (buttons[0], "Volume = " + data.volume.ToString("0"));

//		Sound FX Control
		data.soundFX = GUI.HorizontalSlider(buttons[1], data.soundFX, 0.0F, 100.0F); 
		GUI.Label (buttons[1], "Sound FX = " + data.soundFX.ToString("0"));

		if(GUI.Button (buttons[2], "Main Menu"))
		{
						this.gameObject.GetComponent<MainMenuGUI>().enabled = true;
						Destroy(this);
		}
	}
}
