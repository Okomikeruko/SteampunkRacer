using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Destroyer")
		{
			Destroy (this.gameObject);
		}
	}
}
