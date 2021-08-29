using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CargarNivel : MonoBehaviour {

	public string nombreNivel;
	public float tiempoCarga = 1f;

	// [ContextMenu ("CargandoNivel")]
	public void CargandoNivel() {
		Invoke("CambiarNivel", tiempoCarga);
	}

	private void CambiarNivel() {
		SceneManager.LoadScene(nombreNivel);
	}

	public bool UltimoNivel() {
		return nombreNivel == "Portada"; // Si es el ultimo nivel
	}
}
