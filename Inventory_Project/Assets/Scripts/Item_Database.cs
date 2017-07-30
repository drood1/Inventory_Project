using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public struct Game_Item
{
	public string name;
	public int id;
	public float[] stats;

	/*
		STAT INDICES:
		0: max health
		1: health regen
		2: max mana
		3: mana regen
		4: AP
		5: AD
	*/
	public Game_Item(string n, int i, float max_hp, float hp_regen, float max_mana, float mana_regen, float ap, float ad)	{
		name = n;
		id = i;
		stats = new float[6];
		stats[0] = max_hp;
		stats[1] = hp_regen;
		stats[2] = max_mana;
		stats[3] = mana_regen;
		stats[4] = ap;
		stats[5] = ad;
	}
}

public class Item_Database : MonoBehaviour {
	public List<Game_Item> item_list;


	public void Start()	{
		item_list = new List<Game_Item>();

		Game_Item derp = new Game_Item("derp", 0, 300, 0, 150, 0, 135, 10);
		item_list.Add (derp);

							//(name, id#, max_hp, hp_regen, max_mana, mana_regen, ap, ad)
		Game_Item item1 = new Game_Item("item1", 1, 0, 25, 0, 30, 500, 0);
		item_list.Add (item1);

		Game_Item item2 = new Game_Item("item2", 2, 1000, 250, 0, 30, 500, 0);
		item_list.Add (item2);

		Debug.Log("test");
	}

	public void Update()	{


	}
}
