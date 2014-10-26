using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	delegate void MyDelegate();
	MyDelegate jump;
	MyDelegate fire;

	[SerializeField]
	private float jumpHeight;

	private Animator anim;
	private bool grounded = true;

	// Use this for initialization
	void Start () {
		jump = JumpAction;
		fire = FireAction;

		anim = this.GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump"))
		    { jump(); }
		if (Input.GetButtonDown ("Fire1"))
		    { fire(); }
	}

	void OnCollisionStay2D(Collision2D col)
	{
		if(col.gameObject.tag == "Ground")
		{
			grounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D col)
	{
		if(col.gameObject.tag == "Ground")
		{
			grounded = false;
		}
	}


	public void JumpAction() {
		if(grounded)
		{
			anim.SetTrigger("Jump");
			JumpBehavior();
		}
	}

	public void JumpBehavior()
	{
		this.rigidbody2D.AddForce(Vector2.up * jumpHeight * this.rigidbody2D.mass, ForceMode2D.Impulse);
	}

	public void FireAction() {}
}
