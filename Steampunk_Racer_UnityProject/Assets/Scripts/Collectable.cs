using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	public enum typename {coin, gas, powerup, poison};
	[SerializeField]
	private typename type = new typename();
	[SerializeField] 
	private int value;
	[SerializeField]
	private Transform emitter;

	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Player")
		{
			GameObject.Find("Data").GetComponent<GameData>().collect(type, value);
			Object bomb = Instantiate(emitter, transform.position, Quaternion.identity);
			Destroy(gameObject);
			Destroy(bomb, 0.5f);
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