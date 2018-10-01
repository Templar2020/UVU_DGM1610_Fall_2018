using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	public int PointsToAdd;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
			return;

		ScoreManager.AddPoints (PointsToAdd);

		Destroy (gameObject);
	}
}
