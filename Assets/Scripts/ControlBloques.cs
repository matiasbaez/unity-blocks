using UnityEngine;
using System.Collections;

public class ControlBloques : MonoBehaviour {

	public GameObject efectoParticulas;
	public ControladorPuntos RefPuntos; // Se hace una referencia al componente (objeto) que tenga la clase ControlarPuntos

	void OnCollisionEnter() { // Para los coliders sin el isTrigger activado
		
		Instantiate(efectoParticulas, transform.position, Quaternion.identity);
		// El objeto, la posicion, y la rotacion por defecto

		Destroy(gameObject);
		transform.SetParent(null);
		//gameObject.SetActive(false);

		RefPuntos.AumentarPuntos();
	}
}
