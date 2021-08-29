using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Vidas : MonoBehaviour {

	public Text txtVidas;
	public static int vidas = 3;

	// REFERENCIAS A OTROS COMPONENTES
	public MoverPelota RefPelota; // Se hace referencia al componente (objeto) que tien la clase MoverPelota
	public ControlarBarra RefBarra; // Se hace referencia al componente (objeto) que tien la clase ControlarBarra
	public GameObject GameOver; // El texto de GameOver
	public CargarNivel RefSigNivel;


	// Use this for initialization
	void Start () {
		ActualizarMarcadorVidas();
	}

	void ActualizarMarcadorVidas() {
		txtVidas.text = "Vidas: " + Vidas.vidas.ToString();
	}

	public void RestarVidas() {

		if (vidas <= 0) return;

		Vidas.vidas--;
		ActualizarMarcadorVidas();

		if (vidas < 1) {
			GameOver.SetActive(true); // Se muestra el texto (objeto)
			RefBarra.enabled = false; // Se desactiva el componente dentro del objeto, para que ya no se mueva
			RefSigNivel.CargandoNivel();
		}

		RefBarra.ResetPosBarra (); // Funcion dentro de la clase ControlarBarra
		RefPelota.ResetPosPelota (); // Funcion dentro de la clase MoverPelota

	}
}
