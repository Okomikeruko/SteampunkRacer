using UnityEngine;
using System.Collections;

public class ResetConfirmGUI : MonoBehaviour {

	void OnGUI()
	{
		int w = 300;
		int h = 120;
		int x = (Screen.width - w) / 2;
		int y = ((Screen.height - (h*3/2)) / 2);
		Rect popup = new Rect (x,y,w,h);
		GUI.Box (popup, "Confirm: You wish to reset your game? \n This cannot be undone");
		
		string[] buttons = new string[] {"Confirm", "Cancel"};
		
		for(int i = 0; i < 2; i++)
		{
			if(GUI.Button (new Rect(((Screen.width-80)/2)-100+(200*i),(Screen.height-50)/2,80,50), buttons[i]))
			{
				StatsMenuGUI stats = this.gameObject.GetComponent<StatsMenuGUI>();
				if(buttons[i] == "Confirm")
				{
					GameObject.Find ("Data").GetComponent<GameData>().Playcount = 0;
				}
				stats.SetPopup(false);
				Destroy(this);
			}
		}
	}
}
