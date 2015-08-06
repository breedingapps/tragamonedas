using UnityEngine;
using System.Collections;

public class testposition : MonoBehaviour {

	public GameObject figura;
	public GameObject figura2;
	public GameObject objeto2;
	public GameObject objeto;
	private float ejefigurax;
	private float ejefigura2x;
	private float ejeobjeto;
	private float ejeobjeto2;
	// Use this for initialization
	void Start () {
		//figura.transform.position = new Vector2 (figura.transform.position.x, figura.transform.position.y);
		ejefigurax = figura.transform.position.x;
		ejefigura2x = figura2.transform.position.x;
		ejeobjeto = objeto.transform.position.x;
		ejeobjeto2 = objeto2.transform.position.x;
		//texto2 = figura2.transform.position.x;
		//Debug.Log ("hola" + texto);

		if (ejefigurax == ejeobjeto && ejefigura2x == ejeobjeto2) {
						Debug.Log ("coordenada detectada");
				}else{
			Debug.Log("No se detecto coordenadas");
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
