using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControladorPuntos : MonoBehaviour {

	public Text txtPuntos;
	public GameObject NivelCompletado;
	public GameObject JuegoCompletado;
	public Transform PadreBloques;
	public static int puntos = 0;

	public CargarNivel siguienteNivel;
	public MoverPelota RefPelota;
	public ControlarBarra RefBarra;

	// Use this for initialization
	void Start () {
		ActualizarMarcadorPuntos();
	}

	void ActualizarMarcadorPuntos() {
		txtPuntos.text = "Puntos: " + puntos.ToString();
	}

	public void AumentarPuntos() {

		if (PadreBloques.childCount <= 0) { // Si ya no tiene bloques
			RefPelota.DetenerMovimiento ();
			RefBarra.enabled = false;

			if (siguienteNivel.UltimoNivel()) {
				JuegoCompletado.SetActive (true);
			
			} else {
				NivelCompletado.SetActive (true);
				siguienteNivel.CargandoNivel(); // Se carga el siguiente nivel
			}
		}

		ControladorPuntos.puntos++;
		ActualizarMarcadorPuntos ();
	
	}

}
