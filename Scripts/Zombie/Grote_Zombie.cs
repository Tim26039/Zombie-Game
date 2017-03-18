using UnityEngine;
using System.Collections;

public class Grote_Zombie : MonoBehaviour
{
	Transform player;
	public GameObject speler;
	private UnityEngine.AI.NavMeshAgent nav;
	Animator animatie;
	public float spawntijd = 3f;
	public GameObject enemy;
	public GameObject GroteZombie;
	private GameObject[] aantal;
	Vector3 spawnloacatie;
	float Aantal;
	bool Grond;
	int locatie;
	public int levens;
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
		levens = 10;

	}

	// Update is called once per frame
	void Update () 
	{

		aantal = GameObject.FindGameObjectsWithTag ("Grote_Zombie");
		Aantal = aantal.Length; 
		player = GameObject.Find ("Player").transform;

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


		  for (var i = Aantal; i < 10; i++) 
		  {

			//locatie = Random.Range (0, spawn.Length);
			Instantiate (GroteZombie, new Vector3 (Random.Range (200, 650), 6.6f, Random.Range (200, 310 )), Quaternion.identity);  
			SkinnedMeshRenderer ren = GetComponentInChildren<SkinnedMeshRenderer> ();   
			nav.SetDestination(player.position);

		}

		if (levens == 0) 
		{
			Destroy (gameObject);
		}

	}


	void OnTriggerEnter(Collider other)
	{
		if (other.name == "Player") 
		{
			animatie.SetTrigger ("attack");
			speler.GetComponent<Speler> ().levens -= 60;
			// 1.510   0.5

		}


	}
}
