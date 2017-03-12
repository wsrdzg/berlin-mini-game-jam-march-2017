using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {
	
	private void Update() {
		foreach (Rewired.Player player in Rewired.ReInput.players.AllPlayers) {
			if (player.GetButtonDown(RewiredConsts.Action.Restart))
				SceneManager.LoadScene(0);
			if (player.GetButtonDown(RewiredConsts.Action.Exit))
				Application.Quit();
		}
	}
}