using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour
{
	Transform player;
	public Transform[] spawn;
	public GameObject speler;
	private UnityEngine.AI.NavMeshAgent nav;
	Animator animatie;
	public float spawntijd = 3f;
	public GameObject enemy;
	public GameObject zombie;
	GameObject cavia;
	private GameObject[] aantal;
	Vector3 spawnloacatie;
	float Aantal;
	bool Grond;
	float x;
	float z;
	int locatie;
	bool banaan;
	//public GameObject temp;

	// Use this for initialization
	void Start ()
	{
		player = GameObject.Find ("Player").transform;
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
		animatie = GetComponent <Animator> ();
		nav.enabled = true;
		banaan = false;

	}
	
	// Update is called once per frame
	void Update () 
	{
		aantal = GameObject.FindGameObjectsWithTag ("Zombie");
		Aantal = aantal.Length; 
		player = GameObject.Find ("Player").transform;

			x = Random.Range (150, 610);
			z = Random.Range (200, 510);
		//spawnloacatie = new Vector3 (Random.Range (250, 310) ,6.6f ,Random.Range (250, 310));

		spawntijd -= Time.deltaTime;

		if (banaan == true) 
		{
			nav.SetDestination(player.position);
		}


		if (nav.isOnNavMesh) 
		{
			banaan = true;
			//nav.SetDestination(player.position);
		}

		else 
		{
			Destroy (gameObject);
		}


		for (var i = Aantal; i < 100; i++) 
		{

			//locatie = Random.Range (0, spawn.Length);
			Instantiate (zombie, new Vector3 (Random.Range (200, 650), 6.6f, Random.Range (200, 310 )), Quaternion.identity);  
			SkinnedMeshRenderer ren = GetComponentInChildren<SkinnedMeshRenderer> ();   
			nav.SetDestination(player.position);

		}
			
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.name == "Player") 
		{
			animatie.SetTrigger ("attack");
			speler.GetComponent<Speler> ().levens -= 20;
			// 1.510   0.5

		}


	}
}
