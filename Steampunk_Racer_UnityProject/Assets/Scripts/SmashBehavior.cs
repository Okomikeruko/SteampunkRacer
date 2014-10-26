using UnityEngine;
using System.Collections;

public class SmashBehavior : MonoBehaviour {

	[SerializeField]
	private ParticleSystem DestructionEffect;

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			SmashMe();
		}
	}

	void SmashMe()
	{
		ParticleSystem poof = (ParticleSystem) Instantiate(DestructionEffect, this.transform.position, Quaternion.identity * Quaternion.Euler(300,0,0));
		poof.transform.parent = this.gameObject.transform.parent;
		Destroy (poof.gameObject, 1.0f);
		Destroy (this.gameObject);
	}
}
