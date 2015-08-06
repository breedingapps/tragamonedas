using UnityEngine;
using System.Collections;

public class Boton2 : MonoBehaviour {		
//	private Animator animator;
	private float Tiempo= 5.0f;
	public GameObject fila1;
	public GameObject fila2;
	public GameObject fila3;
	public GameObject fila4;
	public GameObject fila5;
	public GameObject Botonsecundario;
	public GameObject BotonPrimario;
	public TextMesh apuesta;
	public TextMesh win;




	// Use this for initialization
	void Awake(){
		//animator = GetComponent<Animator> ();
		}
	void Start () {

		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax3");
		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax2");
		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax4");
	}

	// Update is called once per frame
	void Update () {

		Tiempo -= Time.deltaTime;
		if (Tiempo <= 3) {
			
			

		}
		if (Tiempo <= 0) {


			Detener();
		}
		
	}
	

	void Detener(){
		NotificationCenter.DefaultCenter ().PostNotification (this,"CilindrosDetenidos");
			//animator.SetBool ("presionar", true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "BotonPresionadoDeNuevo");
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");

		fila1.SetActive (false);

	

		Tiempo = 5.0f;


	}
	void Parallax3(){
		fila3.SetActive (false);

	}
	void Parallax5(){
		fila5.SetActive (false);
		PresionarDeNuevo();
	}
	void Parallax2(){
		fila2.SetActive (false);

	}
	void Parallax4(){
		fila4.SetActive (false);
	}

	   void PresionarDeNuevo(){
		//animator.SetBool ("presionar", false);
		BotonPrimario.SetActive (true);
		Botonsecundario.SetActive (false);



	}

}

