using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CargarScena : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1")) {
			ControladorPuntos.puntos = 0;
			Vidas.vidas = 3;
			SceneManager.LoadScene("Nivel01");
		}

	}
}
