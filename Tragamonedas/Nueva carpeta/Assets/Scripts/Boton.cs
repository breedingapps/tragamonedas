using UnityEngine;
using System.Collections;

public class Boton : MonoBehaviour {		
	//private Animator animator; //ariable para llamar al componente "Animator"
	public GameObject Botonsecundario; //enlace Boton2 
	public GameObject BotonPrimario; 
	public GameObject fila1; //enlaces a la filas
	public GameObject fila2;
	public GameObject fila3;
	public GameObject fila4;
	public GameObject fila5;







	private bool PrimerIntento= false;

	// Use this for initialization
	void Awake(){
		//animator = GetComponent<Animator>();
	}
	void Start () {

			
				
	}


	// Update is called once per frame
	void Update () {



	}
	void OnMouseDown(){
		NotificationCenter.DefaultCenter ().PostNotification (this, "HidePL1");
		NotificationCenter.DefaultCenter ().PostNotification (this, "HidePL2");
		NotificationCenter.DefaultCenter ().PostNotification (this, "HidePL3");
		NotificationCenter.DefaultCenter ().PostNotification (this, "HidePL4");
		NotificationCenter.DefaultCenter ().PostNotification (this, "HidePL5");
		NotificationCenter.DefaultCenter ().PostNotification (this, "HidePL6");
		NotificationCenter.DefaultCenter ().PostNotification (this, "HidePL7");
		NotificationCenter.DefaultCenter ().PostNotification (this, "HidePL8");
		NotificationCenter.DefaultCenter ().PostNotification (this, "HidePL9");
		NotificationCenter.DefaultCenter ().PostNotification (this, "ValoresInicio");

		fila1.SetActive (true);
		fila2.SetActive (true);
		fila3.SetActive (true);
		fila4.SetActive (true);
		fila5.SetActive (true);
		//animator.SetBool ("presionar", true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "BotonPresionado");
	//	audio.Play ();
		Botonsecundario.SetActive (true);
		//animator.SetBool ("presionar", false);	
		BotonPrimario.SetActive (false);
	
	//Invoke ("efecto", audio.clip.length);
	//	if (PrimerIntento) {
						//generador.SetActive (false);
				//}


	}

		
}

