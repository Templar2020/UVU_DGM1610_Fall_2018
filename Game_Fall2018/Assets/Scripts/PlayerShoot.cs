using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	// Shoot Variables
	public Transform FirePoint;
	public GameObject Projectile;
	
	void Start(){
		Projectile = Resources.Load("Prefab/Projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl))
			Instantiate(Projectile,FirePoint.position, FirePoint.rotation);
		
	}
}
