using UnityEngine;
using System.Collections;

public class Schieten : MonoBehaviour 
{
	public GameObject Kogel;
	public GameObject Shotgun;

	// Use this for initialization
	void Start () 
	{
		gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate (Kogel, new Vector3 (transform.position.x, transform.position.y + 0.2f,  transform.position.z), Quaternion.identity);
		}


		if (Input.GetKeyDown (KeyCode.Alpha2))
		{
			Shotgun.SetActive (true);
			gameObject.SetActive (false);
		
		} 

		else
		{
		//	gameObject.SetActive (false);
		}

	}
}
