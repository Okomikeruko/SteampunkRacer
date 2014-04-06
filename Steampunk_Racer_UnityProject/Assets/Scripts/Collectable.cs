using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	[SerializeField] 
	private string type;
	[SerializeField] 
	private int value;
	[SerializeField]
	private Transform emitter;

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
		Object bomb = Instantiate(emitter, transform.position, Quaternion.identity);
		Destroy(gameObject);
		Destroy(bomb, 0.5f);
	}

}