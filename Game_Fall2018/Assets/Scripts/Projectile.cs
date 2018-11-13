using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float Speed;
	public GameObject PC;

	public GameObject EnemyDeath;

	public GameObject ProjectileParticle;

	public int PointsForKill;

	public int TimeOut;

	// Use this for initialization
	void Start () {
		 PC = GameObject.Find("PC");

		 EnemyDeath = Resources.Load("Prefab/Particle") as GameObject;
		 ProjectileParticle = Resources.Load("Prefab/Particle") as GameObject;
		 
		if(PC.transform.localScale.x < 0)
			Speed = -Speed;

			// Speed = Speed * Mathf.Sign(PC.transform.localScale.x);

			// GetComponent<Rigidbody2D>().velocity = new Vector2(Speed + (PC.GetComponent<Rigidbody2D>().velocity.x/3),GetComponent<Rigidbody2D>().velocity.y + (PC.GetComponent<Rigidbody2D>().velocity.y/3));

		Destroy(gameObject,TimeOut);
			
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (PointsForKill);
		}		
		
		Destroy (gameObject);
	}

	void OnCollisionEnter2D(Collision2D other){		
			Instantiate(ProjectileParticle, transform.position, transform.rotation);
			Destroy (gameObject);			
	}
}
 