using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {
	
	void Update() {
		foreach (Rewired.Player p in Rewired.ReInput.players.AllPlayers)
			if (p.GetButtonDown("Restart")) {
				SceneManager.LoadScene (0);
			}
	}
}