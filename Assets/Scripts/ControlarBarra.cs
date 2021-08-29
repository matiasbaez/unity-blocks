using UnityEngine;
using System.Collections;

public class ControlarBarra : MonoBehaviour {

	public float velocidad = 10f;

	private Vector3 posInicialBarra;

	// Use this for initialization
	void Start () {
		posInicialBarra = transform.position;
	}

	public void ResetPosBarra() {
		transform.position = posInicialBarra;
	}

	// Update is called once per frame
	void Update () {
		float posHorizontal = Input.GetAxis("Horizontal");;
		float posicionX = transform.position.x + (posHorizontal * velocidad * Time.deltaTime); // Pos por fotograma
		// Posicion inicial + posicionHorizontal

		transform.position = new Vector3(Mathf.Clamp(posicionX, -8, 8), transform.position.y, 0);
		//Mathf.Clamp(valor, minimo, maximo)

	}

}
