using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	// Shoot Variables
	public Transform FirePoint;
	public GameObject Projectile;
	
	void Start(){
		//Projectile = GameObject.Find("Projectile"); 
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl))
			Instantiate(Projectile,FirePoint.position, FirePoint.rotation);
		
	}
}
