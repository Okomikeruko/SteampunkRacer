using UnityEngine;
using System.Collections;

public class StatsGUI : MonoBehaviour {

	[SerializeField]
	private string Game;

	private GUIStyle Title = new GUIStyle();
	private GUIStyle Subtitle = new GUIStyle();

	private Rect[] buttons = new Rect[2];

	private string plays;	
	private string[] buttonName = new string[2];
	private string[] menuName = new string[2];

	void Start()
	{
		plays = GameObject.Find ("Data").GetComponent<GameData>().Playcount.ToString();
		
		Title.fontSize = 45;
		Title.alignment = TextAnchor.MiddleCenter;
		Title.normal.textColor = Color.white;

		Subtitle.fontSize = 30;
		Subtitle.alignment = TextAnchor.MiddleCenter;
		Subtitle.normal.textColor = Color.white;

		buttonName = new string[] {"Replay", "Main Menu"};
		menuName = new string[] {Game, "menus"};

		for(int i = 0; i < 2; i++)
		{
			buttons[i] = new Rect(((Screen.width-80)/2)-100+(200*i),(Screen.height-50)/2,80,50);
		}
	}

	void OnGUI()
	{
		GUI.Label (new Rect((Screen.width/2)-200, (Screen.height/2)-200, 400, 100), "Game Over", Title);
		GUI.Label (new Rect((Screen.width/2)-200, (Screen.height/2)-125, 400, 100), "You have played " + plays + " times.", Subtitle);

		for(int i = 0; i < 2; i++)
		{
			if(GUI.Button (buttons[i], buttonName[i]))
			{
				Application.LoadLevel (menuName[i]);
			}
		}
	}
}
