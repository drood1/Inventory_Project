using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Stats : MonoBehaviour {
	public float max_hp = 100;
	public float current_hp;
	public float max_mana = 100;
	public float current_mana;

	public float AP = 25;
	public float AD = 75;

	public float hp_regen = 5;
	public float mana_regen = 7;


	public Item_Database database;

	//public Image hp_bar;
	//public Image mana_bar;

	//creates an array of 6 Item objects
	//public float[database.Game_Item()] inventory = new float[6];


	public void AddItem(int item_id)	{
		
		//iterates through a database of items (item_list) and checks each item's ID in the database to the item_id that needs to be added
		for(int i = 0; i < database.item_list.Count; i++)	{
			//once the proper item is found in the database, add that item's stats to this player
			if(item_id == database.item_list[i].id)	{
				//add stats of item to the player
				/*
					STAT INDICES:
					0: max health
					1: health regen
					2: max mana
					3: mana regen
					4: AP
					5: AD
				*/
				max_hp += database.item_list [i].stats [0];
				hp_regen += database.item_list [i].stats [1];
				max_mana += database.item_list [i].stats [2];
				mana_regen += database.item_list [i].stats [3];
				AP += database.item_list [i].stats [4];
				AD += database.item_list [i].stats [5];
				//add the Item to the "inventory" array
				//inventory.Add(database.item_list[i]);
			}

		}
	}


	void Regen()	{
		current_hp += hp_regen;
		current_mana += mana_regen;
		if (current_hp > max_hp)
			current_hp = max_hp;
		if (current_mana > max_mana)
			current_mana = max_mana;
	}

	// Use this for initialization
	void Start () {
		current_hp = max_hp;
		current_mana = max_mana;
		//decrease the 3rd parameter to increase the tick rate of regen
		InvokeRepeating ("Regen", 0, 1f);	

		database = GameObject.Find ("Database_obj").GetComponent<Item_Database> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.H))
			current_hp -= 40;
		if (Input.GetKeyDown (KeyCode.M))
			current_mana -= 25;


		//hp_bar.fillAmount = current_hp/max_hp;
		//mana_bar.fillAmount = current_mana/max_mana;
	}
}
