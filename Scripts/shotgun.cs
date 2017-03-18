using UnityEngine;
using System.Collections;

public class shotgun : MonoBehaviour {

	public GameObject Kogel;
	public GameObject pistol;

	// Use this for initialization
	void Start () 
	{
		gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () 
	{

		if (Input.GetMouseButtonDown(0))
		{
			Instantiate (Kogel, new Vector3 (transform.position.x, transform.position.y + 0.2f,  transform.position.z), Quaternion.identity);
		}

		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			gameObject.SetActive (false);
			pistol.SetActive (true);
		}
	}
}
