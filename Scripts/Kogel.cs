using UnityEngine;
using System.Collections;

public class Kogel : MonoBehaviour
{
	float snelheid;
	public GameObject speler;
	public GameObject speler1;
	Vector3 Speler;
	public GUISkin tekstscore;

	// Use this for initialization
	void Start () 
	{
		snelheid = 24;
		Speler = speler.transform.eulerAngles;
		transform.eulerAngles = Speler;
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<Rigidbody>().velocity =  transform.forward * -snelheid;
	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Zombie" || other.gameObject.tag == "Zombietje") 
		{
			Destroy(gameObject);
			Destroy (other.gameObject);
			speler1.GetComponent<Speler> ().score += 10;
		}

		if (other.gameObject.tag == "Grote_Zombie") 
		{
			other.gameObject.GetComponent<Grote_Zombie> ().levens -= 1;
			Destroy(gameObject);
			speler1.GetComponent<Speler> ().score += 10;
		}


		if (other.gameObject.name == "Levens" &&  speler1.GetComponent<Speler> ().score >= speler1.GetComponent<Speler> ().kost && speler1.GetComponent<Speler> ().levens < 300) 
		{
			Destroy(gameObject);
			speler1.GetComponent<Speler> ().levens += 20;
			speler1.GetComponent<Speler> ().score -= speler1.GetComponent<Speler> ().kost;
			speler1.GetComponent<Speler> ().kost += 50;
		}

		Destroy (gameObject);
	}

	void OnGUI()
	{
		GUI.skin = tekstscore;
		GUI.Label(new Rect(10, 35, 300, 300), "Score: " + speler1.GetComponent<Speler> ().score);
	}
}
