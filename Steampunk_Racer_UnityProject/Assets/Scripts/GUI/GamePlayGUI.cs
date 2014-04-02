using UnityEngine;
using System.Collections;

public class GamePlayGUI : MonoBehaviour {

	private float square;
	private float top;
	private float bottom;
	private float left;
	private float right;

	private Rect AttackButton;
	private Rect PauseButton;
	private Rect JumpButton;
	private Rect SuicideButton; 

	void Update()
	{
		square = Screen.height / 10;

		top = 5.0f;
		bottom = Screen.height - (top + square);
		left = 5.0f;
		right = Screen.width - (left + square);

		AttackButton = new Rect(right, bottom, square, square);
		PauseButton = new Rect(right, top, square, square);
		JumpButton = new Rect(left, bottom, square, square);
		SuicideButton = new Rect(left, top, square, square); 

	}

	void OnGUI()
	{
		if(GUI.Button (AttackButton, "Attack"))
		{
			// This is where you put the attack function.
		}

		if(GUI.Button (PauseButton, "Pause"))
		   {
			
		}

		if(GUI.Button (JumpButton, "Jump"))
		   {
			
		}

		if(GUI.Button (SuicideButton, "Suicide"))
		   {
			Application.LoadLevel("menus");
		}

	}
}
