using UnityEngine;
using System.Collections;

public class Speler : MonoBehaviour 
{
	public int levens;
	public int levensrood;
	public GameObject Bullet;
	public int score;
	public int kost;
	bool text;
	public GUISkin tekstscore;

	// Use this for initialization
	void Start () 
	{
		levens = 200;
		levensrood = 200;
		score = 1000;
		kost = 100;
		text = false;
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (levens == 0) 
		{
			Destroy (gameObject);
		}

		if (levens > levensrood)
		{
			levensrood = levens;
		}
			
	}

	void OnTriggerEnter(Collider automaat)
	{
		if (automaat.gameObject.name == "Levens") 
		{
			text = true;
		}
	}

	void OnTriggerExit (Collider iets)
	{
		text = false;
	}

	void OnGUI ()
	{
		GUI.backgroundColor = Color.red;
		GUI.Button(new Rect(5, 5, levensrood, 30), "");
		GUI.backgroundColor = Color.red;
		GUI.Button(new Rect(5, 5, levensrood, 30), "");
		GUI.backgroundColor = Color.red;
		GUI.Button(new Rect(5, 5, levensrood, 30), "");
		GUI.backgroundColor = Color.red;
		GUI.Button(new Rect(5, 5, levensrood, 30), "");

		GUI.backgroundColor = Color.green;
		GUI.Button(new Rect(5, 5, levens, 30), "");
		GUI.backgroundColor = Color.green;
		GUI.Button(new Rect(5, 5, levens, 30), "");
		GUI.backgroundColor = Color.green;
		GUI.Button(new Rect(5, 5, levens, 30), "");
		GUI.backgroundColor = Color.green;
		GUI.Button(new Rect(5, 5, levens, 30), "");

		if (text == true) 
		{
			GUI.skin = tekstscore;
			GUI.Label(new Rect(450, 500, 300, 300), "Levens   Kost: " +  kost);
		}
	}
}
