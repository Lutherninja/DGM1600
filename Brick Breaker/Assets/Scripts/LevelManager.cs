using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	private int brickCount;


	void Start(){
		brickCount = FindObjectsOfType<Health> ().Length;
		print (brickCount);
	}



	public void Levelload (string lvl) {
		SceneManager.LoadScene (lvl);
	}

	public void ExitGame (){
		print ("Tried to Exit");
		Application.Quit ();

	}

	public void LoadNextLevel () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

	
	}
	public void UpdateBrickCount () {
		brickCount = FindObjectsOfType<Health> ().Length;
		if (brickCount <= 0) {
			LoadNextLevel ();
		}
	
	
	}
}
