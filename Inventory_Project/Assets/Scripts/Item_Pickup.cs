using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Pickup : MonoBehaviour {
	public int item_id;

	public void OnTriggerEnter(Collider col)	{
		if (col.gameObject.tag == "Player") {
			col.gameObject.GetComponent<Player_Stats> ().AddItem (item_id);
			Destroy (this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
