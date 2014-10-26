using UnityEngine;
using System.Collections;

public class TerrainMotion : MonoBehaviour {

	delegate void MyDelegate();
	MyDelegate run;

	[SerializeField]
	private float StartSpeed;
	[SerializeField]
	private float SpeedLimit;
	[SerializeField]
	private float Acceleration;
	[SerializeField]
	private GameObject TerrainObject;
	[SerializeField]
	private GameObject Ground;

	
	private float Speed;
	private Vector3 groundSpawnOffset = new Vector3(10, 0, 0);
	private Animator anim;


	void Start () {
		run = MoveTerrain;
		run += GenerateTerrain;
		run += Accelerate;
		Speed = StartSpeed;
		anim = GameObject.Find("Robot Kyle").GetComponent<Animator>();
	}

	void Update () {
		run();
	}

	public void SetSpeed(float s)
	{
		Speed = Mathf.Clamp(s, 0, SpeedLimit);
	}

	public float GetSpeed()
	{
		return Speed;
	}

	public void SetAcceleration (float a)
	{
		Acceleration = Mathf.Clamp (a, 0.01F, 100);
	}

	public float GetAcceleration()
	{
		return Acceleration;
	}

	private void MoveTerrain()
	{
		TerrainObject.transform.position += Vector3.left * Speed * Time.deltaTime;
		if (GameObject.FindGameObjectsWithTag("Ground").Length < 10)
		{
			run += GenerateTerrain;
		}
	}

	private void GenerateTerrain()
	{
		run -= GenerateTerrain;
		Ground = (GameObject) Instantiate (Resources.Load("GroundBlock",typeof(GameObject)), Ground.transform.position + groundSpawnOffset, Quaternion.identity);
		Ground.transform.parent = TerrainObject.transform;
	}

	private void Accelerate()
	{
		SetSpeed (Speed + Time.deltaTime / Acceleration);
		anim.SetFloat ("RunningSpeed", Mathf.Clamp (Speed / StartSpeed, 1, 25));
		if (Speed == SpeedLimit)
			{run -=Accelerate;}
	}
}
