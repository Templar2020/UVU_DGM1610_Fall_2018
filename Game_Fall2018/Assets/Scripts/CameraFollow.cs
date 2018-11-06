using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public CharacterMove PC;

	public bool isFollowing;


	// Camera position offset
	public float xOffset;
	public float yOffset;

	// Use this for initialization
	void Start () {
		PC = FindObjectOfType<CharacterMove>();

		isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(isFollowing){
			transform.position = new Vector3(PC.transform.position.x + xOffset, PC.transform.position.y + yOffset, transform.position.z);
	
		}
	}

}
