using UnityEngine;
using System.Collections;

public class ControlarSuelo : MonoBehaviour {

	public Vidas RefVidas; // Se hace una referencia al componente (objeto) que tenga la clase Vidas

	void OnTriggerEnter() {
		RefVidas.RestarVidas(); // Funcion que esta dentro de la clase Vidas
	}
}
