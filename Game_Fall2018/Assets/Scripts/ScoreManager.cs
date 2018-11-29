using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public static int Score;
	public int WinScore;	

	public Text WinText;

	Text ScoreText;

	void Awake(){
		Time.timeScale = 1;
	}
	
	// Use this for initialization
	void Start () {
		ScoreText = GetComponent<Text>();

		Score = 0;

		WinText.GetComponent<Text>().enabled = false;
 	}
	
	// Update is called once per frame
	void Update () {
		if (Score < 0)
			Score = 0; 
		ScoreText.text = " " + Score;

		// If the player win display win text
		if(Score >= WinScore ){
			print("Win Score Reached = " + Score);
			WinText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
		// If player hits the Escape key return to start menu
		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}

	}

	public static void AddPoints (int PointsToAdd) {
		
		Score += PointsToAdd;
	
	}
	
	

}
