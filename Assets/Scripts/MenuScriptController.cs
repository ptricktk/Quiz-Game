using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScriptController : MonoBehaviour {

	public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
	
}
