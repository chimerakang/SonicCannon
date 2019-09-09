using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitApplication : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ExitGame()
	{
		Application.Quit();
	}

	public void BackToUpLayer()
	{
        UnityEngine.SceneManagement.SceneManager.LoadScene (0);
	}
}
