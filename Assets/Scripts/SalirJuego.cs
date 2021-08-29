using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SalirJuego : MonoBehaviour {

	public bool salir;
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (salir) {
				Application.Quit ();
			} else {
				SceneManager.LoadScene("Portada");
			}
		}
			

	}
}
