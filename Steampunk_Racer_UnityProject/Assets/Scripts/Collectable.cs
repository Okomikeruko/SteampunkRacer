using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	[SerializeField] 
	private string type;
	[SerializeField] 
	private int value;

	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Player")
		{
			GameObject.Find("Data").GetComponent<GameData>().collect(type, value);
			Destroy(this);
		}
	}

	void OnMouseDown()
	{
		GameObject.Find("Data").GetComponent<GameData>().collect(type, value);
		Destroy(gameObject);
	}

}