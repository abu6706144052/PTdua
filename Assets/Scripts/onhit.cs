using UnityEngine;
using System.Collections;

public class onhit : MonoBehaviour {
	
	public GameObject Camera;
	public GameScript Script;
	
	void Awake()
	{
		Script = Camera.GetComponent<GameScript>();
	}
	
	void onMouseDown()
	{
		Script.SpawnNew(this.gameObject);
	}
}
