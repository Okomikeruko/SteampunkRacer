using UnityEngine;
using System.Collections;

public class PauseGUI : MonoBehaviour {

	void OnGUI()
	{
		int w = 300;
		int h = 120;
		int x = (Screen.width - w) / 2;
		int y = ((Screen.height - (h*3/2)) / 2);
		Rect popup = new Rect (x,y,w,h);
		GUI.Box (popup, "Paused");
		
		string[] buttons = new string[] {"Continue", "Main Menu"};
		
		for(int i = 0; i < 2; i++)
		{
			if(GUI.Button (new Rect(((Screen.width-80)/2)-100+(200*i),(Screen.height-50)/2,80,50), buttons[i]))
			{
				GetComponent<GamePlayGUI>().unpause();

				if(buttons[i] == "Continue")
				{
					Destroy(this);
				}

				if(buttons[i] == "Main Menu")
				{
					Application.LoadLevel("menus");
				}
			}
		}
	}
}
