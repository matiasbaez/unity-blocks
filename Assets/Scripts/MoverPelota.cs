using UnityEngine;
using System.Collections;

public class MoverPelota : MonoBehaviour {

	public float velocidad = 100f;

	private Rigidbody cuerpoRig;
	private Vector3 posInicialPelota;
	private bool jugando = false;
	public Transform refBarra;


	void Awake() {
		cuerpoRig = GetComponent<Rigidbody>();
		//refBarra = GetComponentInChildren<Transform>(); // Obtiene la referencia de la barra
		//Debug.Log("Pelota parent in Awake: " + refBarra.ToString());
		posInicialPelota = transform.position;
	}

	public void ResetPosPelota() {
		transform.position = posInicialPelota;
		//Debug.Log("Pelota parent: " + refBarra.ToString());
		transform.SetParent(refBarra); // Se le vuelve a asignar el objeto padre a la pelota
		DetenerMovimiento();
		jugando = false;
	}

	public void DetenerMovimiento() {
		cuerpoRig.isKinematic = true;
		cuerpoRig.velocity = Vector3.zero; // se le quita la velcidad a la pelota
	}

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!jugando && Input.GetButtonDown("Fire1")) { // Fire1 es la tecla, definida en la configuracion del proyecto
			jugando = true;

			transform.SetParent(null); // La pelota deja de ser hija de la barra
			cuerpoRig.isKinematic = false; // Se desactiva el kinematic al rigidbody
			cuerpoRig.AddForce(new Vector3(velocidad, velocidad, 0));

		}

	}

	/* void OnCollisionEnter(Collision objeto) {
		if (objeto.gameObject.CompareTag ("Finish")) {
			// Debug.Log("Ha colisionado con: " + objeto.gameObject.name);
			ResetPosPelota();
		}
	} */
}
