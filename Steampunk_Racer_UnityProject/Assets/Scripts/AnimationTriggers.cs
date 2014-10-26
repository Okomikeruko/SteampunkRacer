using UnityEngine;
using System.Collections;

public class AnimationTriggers : MonoBehaviour {

	private PlayerControl pc;

	void Start()
	{
		pc = GetComponentInParent<PlayerControl>();
	}

	void CallJump()
	{
		pc.JumpBehavior();
	}
}
