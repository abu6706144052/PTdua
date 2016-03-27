using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {
	
	public GameObject panelm, panelb;
	public enum Seed { EMPTY, PANELM, PANELB } ;
	public Seed turn;
	
	public void SpawnNew(GameObject obj)
	{
		if (turn == Seed.PANELM) {
			Instantiate (panelm, obj.transform.position, Quaternion.identity);
			turn = Seed.PANELB;
		} else 
		{
			Instantiate(panelb, obj.transform.position, Quaternion.identity);
			turn = Seed.PANELM;
		}
		Destroy (obj.gameObject);
	}	
}