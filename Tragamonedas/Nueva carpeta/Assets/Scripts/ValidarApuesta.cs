using UnityEngine;
using System.Collections;

public class ValidarApuesta : MonoBehaviour {


	private float timeRemaining = 10.0f;

	public GameObject Payline1;
	public GameObject Payline2;
	public GameObject Payline3;
	public GameObject Payline4;
	public GameObject Payline5;
	public GameObject Payline6;
	public GameObject Payline7;
	public GameObject Payline8;
	public GameObject Payline9;
	public GameObject CameraNoCoins;
	public GameObject BPL1;
	public GameObject BPL2;
	public GameObject BPL3;
	public GameObject CameraMoreCoins;

	public TextMesh tiempo;
	public TextMesh apuesta;
	public TextMesh monedas;
	public TextMesh win;
	public TextMesh paylines;

	private int PL= 1;
	private int monto = 0;
	private int gobackmonto= 0;
	private int ApuestaMonedas=0;
	private int ApuestaD=0;
	public int TotalMonedas = 0;
	private int Ganancia = 0;
	public int Tmonedas= 0;

	private int GMC=50;

	private int GA1= 0;
	private int GA2= 0;
	private int GA3= 0;
	private int GA4= 0;
	private int GA5= 0;
	private int GA6= 0;
	private int GA7= 0;

	private int GB1= 0;
	private int GB2= 0;
	private int GB3= 0;
	private int GB4= 0;
	private int GB5= 0;
	private int GB6= 0;
	private int GB7= 0;

	private int GC1= 0;
	private int GC2= 0;
	private int GC3= 0;
	private int GC4= 0;
	private int GC5= 0;
	private int GC6= 0;
	private int GC7= 0;

	private int GP4L1= 0;
	private int GP4L2= 0;
	private int GP4L3= 0;
	private int GP4L4= 0;
	private int GP4L5= 0;
	private int GP4L6= 0;
	private int GP4L7= 0;

	private int GP5L1= 0;
	private int GP5L2= 0;
	private int GP5L3= 0;
	private int GP5L4= 0;
	private int GP5L5= 0;
	private int GP5L6= 0;
	private int GP5L7= 0;

	private int GP6L1= 0;
	private int GP6L2= 0;
	private int GP6L3= 0;
	private int GP6L4= 0;
	private int GP6L5= 0;
	private int GP6L6= 0;
	private int GP6L7= 0;

	private int GP7L1= 0;
	private int GP7L2= 0;
	private int GP7L3= 0;
	private int GP7L4= 0;
	private int GP7L5= 0;
	private int GP7L6= 0;
	private int GP7L7= 0;

	private int GP8L1= 0;
	private int GP8L2= 0;
	private int GP8L3= 0;
	private int GP8L4= 0;
	private int GP8L5= 0;
	private int GP8L6= 0;
	private int GP8L7= 0;

	private int GP9L1= 0;
	private int GP9L2= 0;
	private int GP9L3= 0;
	private int GP9L4= 0;
	private int GP9L5= 0;
	private int GP9L6= 0;
	private int GP9L7= 0;






	
	// Use this for initialization
	void Awake(){

	}
	void Start () {
		Tmonedas = 500;
		TotalMonedas= Tmonedas + Ganancia;
		monedas.text = TotalMonedas.ToString ();
		Actualizar ();
		NotificationCenter.DefaultCenter ().AddObserver (this,"CilindrosDetenidos");
		NotificationCenter.DefaultCenter ().AddObserver (this, "refresh");
		NotificationCenter.DefaultCenter().AddObserver(this, "bringmonto1");
		NotificationCenter.DefaultCenter().AddObserver(this, "bringmonto2");
		NotificationCenter.DefaultCenter().AddObserver(this, "bringmonto3");
		NotificationCenter.DefaultCenter().AddObserver(this, "bringmonto4");
		NotificationCenter.DefaultCenter().AddObserver(this, "AumentarApuesta");
		NotificationCenter.DefaultCenter().AddObserver(this, "RestarApuesta");
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPL2");
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPL1");

//-..................................................................................

		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1A5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1A4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1A3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2A5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2A4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2A3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3A5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3A4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3A3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4A5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4A4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4A3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5A5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5A4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5A3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6A5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6A4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6A3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7A5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7A4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7A3");

//......................................................................................

		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1B5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1B4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1B3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2B5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2B4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2B3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3B5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3B4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3B3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4B5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4B4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4B3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5B5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5B4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5B3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6B5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6B4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6B3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7B5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7B4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7B3");

//.........................................................................................

		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1C5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1C4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1C3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2C5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2C4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2C3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3C5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3C4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3C3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4C5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4C4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4C3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5C5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5C4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5C3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6C5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6C4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6C3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7C5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7C4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7C3");

//......................................................................................

		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P4L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P4L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P4L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P4L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P4L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P4L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P4L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P4L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P4L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P4L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P4L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P4L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P4L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P4L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P4L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P4L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P4L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P4L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P4L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P4L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P4L3");

//...........................................................................................

		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P5L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P5L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P5L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P5L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P5L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P5L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P5L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P5L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P5L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P5L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P5L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P5L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P5L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P5L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P5L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P5L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P5L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P5L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P5L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P5L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P5L3");

//.......................................................................................

		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P6L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P6L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P6L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P6L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P6L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P6L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P6L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P6L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P6L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P6L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P6L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P6L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P6L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P6L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P6L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P6L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P6L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P6L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P6L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P6L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P6L3");

//..........................................................................................

		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P7L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P7L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P7L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P7L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P7L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P7L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P7L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P7L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P7L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P7L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P7L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P7L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P7L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P7L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P7L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P7L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P7L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P7L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P7L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P7L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P7L3");

//..........................................................................................
		
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P8L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P8L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P8L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P8L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P8L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P8L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P8L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P8L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P8L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P8L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P8L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P8L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P8L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P8L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P8L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P8L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P8L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P8L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P8L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P8L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P8L3");
	
//..........................................................................................
		
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P9L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P9L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1P9L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P9L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P9L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura2P9L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P9L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P9L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura3P9L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P9L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P9L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura4P9L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P9L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P9L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura5P9L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P9L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P9L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura6P9L3");
		//------------------------------------------------------------------------
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P9L5");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P9L4");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura7P9L3");

		NotificationCenter.DefaultCenter ().AddObserver (this, "Parallax5");
		NotificationCenter.DefaultCenter ().AddObserver (this, "MoreCoins");
	}

	void ActivarPayline2(){
		Payline2.SetActive (true);
	}
	void ActivarPayline3(){
		Payline3.SetActive (true);
	}
	void ActivarPayline4(){
		Payline4.SetActive (true);
	}
	void ActivarPayline5(){
		Payline5.SetActive (true);
	}
	void ActivarPayline6(){
		Payline6.SetActive (true);
	}
	void ActivarPayline7(){
		Payline7.SetActive (true);
	}
	void ActivarPayline8(){
		Payline8.SetActive (true);
	}
	void ActivarPayline9(){
		Payline9.SetActive (true);
	}
//...............................
	void DesactivarPayline2(){
		Payline2.SetActive (false);
	}
	void DesactivarPayline3(){
		Payline3.SetActive (false);
	}
	void DesactivarPayline4(){
		Payline4.SetActive (false);
	}
	void DesactivarPayline5(){
		Payline5.SetActive (false);
	}
	void DesactivarPayline6(){
		Payline6.SetActive (false);
	}
	void DesactivarPayline7(){
		Payline7.SetActive (false);
	}
	void DesactivarPayline8(){
		Payline8.SetActive (false);
	}
	void DesactivarPayline9(){
		Payline9.SetActive (false);
	}
//...............................
	void CheckPayLines(){

		if (PL == 1) {
			DesactivarPayline2();
			DesactivarPayline3();
			DesactivarPayline4();
			DesactivarPayline5();
			DesactivarPayline6();
			DesactivarPayline7();
			DesactivarPayline8();
			DesactivarPayline9();		
		}
		if (PL == 2) {
			ActivarPayline2();
			DesactivarPayline3();
			DesactivarPayline4();
			DesactivarPayline5();
			DesactivarPayline6();
			DesactivarPayline7();
			DesactivarPayline8();
			DesactivarPayline9();
		}

		if (PL == 3) {
			ActivarPayline3();
			DesactivarPayline4();
			DesactivarPayline5();
			DesactivarPayline6();
			DesactivarPayline7();
			DesactivarPayline8();
			DesactivarPayline9();
		}
		if (PL == 4) {
			ActivarPayline4();	
			DesactivarPayline5();
			DesactivarPayline6();
			DesactivarPayline7();
			DesactivarPayline8();
			DesactivarPayline9();
		}
		if (PL == 5) {
			ActivarPayline5();
			DesactivarPayline6();
			DesactivarPayline7();
			DesactivarPayline8();
			DesactivarPayline9();
		}
		if (PL == 6) {
			ActivarPayline6();
			DesactivarPayline7();
			DesactivarPayline8();
			DesactivarPayline9();
		}
		if (PL == 7) {
			ActivarPayline7();
			DesactivarPayline8();
			DesactivarPayline9();
		}
		if (PL == 8) {
			ActivarPayline8();
			DesactivarPayline9();
		}
		if (PL == 9) {
			ActivarPayline9();		
		}
	}



	void BotonPL1(){
		if (PL > 1) {
			PL = PL - 1;
			paylines.text = PL.ToString ();
			CheckPayLines();
			Actualizar();
		}
	}
	
	void BotonPL2(){
		if (PL < 9) {
			PL = PL + 1;
			paylines.text = PL.ToString ();
			CheckPayLines();
			Actualizar();
		}
	}

	//.........................................................................

	void RestarApuesta(){
		if (monto > 3) {

						if (PL == 1) {
								Tmonedas +=gobackmonto;
								iniciomonto();
								monedas.text= Tmonedas.ToString();
								apuesta.text= "0";
								
						}
			
						if (PL == 2) {
				Tmonedas +=gobackmonto;
				iniciomonto();
				monedas.text= Tmonedas.ToString();
				apuesta.text= "0";
						}
			
						if (PL == 3) {
				Tmonedas +=gobackmonto;
				iniciomonto();
				monedas.text= Tmonedas.ToString();
				apuesta.text= "0";
						}
			
						if (PL == 4) {
				Tmonedas +=gobackmonto;
				iniciomonto();
				monedas.text= Tmonedas.ToString();
				apuesta.text= "0";
						}
			
						if (PL == 5) {
				Tmonedas +=gobackmonto;
				iniciomonto();
				monedas.text= Tmonedas.ToString();
				apuesta.text= "0";
						}
			
						if (PL == 6) {
				Tmonedas +=gobackmonto;
				iniciomonto();
				monedas.text= Tmonedas.ToString();
				apuesta.text= "0";
						}
			
						if (PL == 7) {
				Tmonedas +=gobackmonto;
				iniciomonto();
				monedas.text= Tmonedas.ToString();
				apuesta.text= "0";
						}
			
						if (PL == 8) {
				Tmonedas +=gobackmonto;
				iniciomonto();
				monedas.text= Tmonedas.ToString();
				apuesta.text= "0";
						}
			
						if (PL == 9) {
				Tmonedas +=gobackmonto;
				iniciomonto();
				monedas.text= Tmonedas.ToString();
				apuesta.text= "0";
						}
						TotalMonedas = Tmonedas;
						

				} else {
						Debug.Log ("No tiene nada en apuesta");

				}
		}

	void iniciomonto (){
		gobackmonto = 0;

	}
	void AumentarApuesta(){
		//Lo que ve el usuario en la caja de apuesta
		if (Tmonedas > 1) {
						if (PL == 1) {
								gobackmonto += 5;
								Tmonedas = Tmonedas - 5;

						}

						if (PL == 2) {
								gobackmonto += 10;
								Tmonedas = Tmonedas - 10;

						}

						if (PL == 3) {
								gobackmonto += 15;
								Tmonedas = Tmonedas - 15;
								
						}

						if (PL == 4) {
								gobackmonto += 20;
								Tmonedas = Tmonedas - 20;

						}

						if (PL == 5) {
								gobackmonto += 25;
								Tmonedas = Tmonedas - 25;

						}

						if (PL == 6) {
								gobackmonto += 50;
								Tmonedas = Tmonedas - 50;

						}

						if (PL == 7) {
								gobackmonto += 70;
								Tmonedas = Tmonedas - 70;

						}

						if (PL == 8) {
								gobackmonto += 85;
								Tmonedas = Tmonedas - 85;

						}

						if (PL == 9) {
								gobackmonto += 100;
								Tmonedas = Tmonedas - 100;

						}
						//TotalMonedas = Tmonedas;
						monto= gobackmonto;
		
						Actualizar ();
				}else{
			//Debug.Log("no tiene mas dinero");
			//CamaraNoCoins.SetActive(true);
			//NotificationCenter.DefaultCenter().PostNotification(this,"showActive");
		}
			}
	void refresh(){
		monedas.text = TotalMonedas.ToString ();
		Debug.Log (TotalMonedas);
		//bringmonto1 ();
	}

	void Parallax5(){
		if (TotalMonedas == 0) {
			
			CameraNoCoins.SetActive(true);
		}
	}
	private bool Timeout= false;
	void MoreCoins(){
		Timeout = true;
		Inicio ();
		}

	void Inicio(){
				
				//aqui la suma de la ganancia con el total de monedas 
				gobackmonto = 0;
				monto = 0;//La apuesta que hace el usuario
				win.text = Ganancia.ToString ();
				if (!Timeout) {
						Ganancia = GA1 + GA2 + GA3 + GA4 + GA5 + GA6 + GA7 + GB1 + GB2 + GB3 + GB4 + GB5 + GB6 + GB7 + GC1 + GC2 + GC3 + GC4 + GC5 + GC6 + GC7 + GP4L1 + GP4L2 + GP4L3 + GP4L4 + GP4L5 + GP4L6 + GP4L7 + GP5L1 + GP5L2 + GP5L3 + GP5L4 + GP5L5 + GP5L6 + GP5L7 + GP6L1 + GP6L2 + GP6L3 + GP6L4 + GP6L5 + GP6L6 + GP6L7 + GP7L1 + GP7L2 + GP7L3 + GP7L4 + GP7L5 + GP7L6 + GP7L7 + GP8L1 + GP8L2 + GP8L3 + GP8L4 + GP8L5 + GP8L6 + GP8L7 + GP9L1 + GP9L2 + GP9L3 + GP9L4 + GP9L5 + GP9L6 + GP9L7;
				} else {
						Ganancia = GA1 + GA2 + GA3 + GA4 + GA5 + GA6 + GA7 + GB1 + GB2 + GB3 + GB4 + GB5 + GB6 + GB7 + GC1 + GC2 + GC3 + GC4 + GC5 + GC6 + GC7 + GP4L1 + GP4L2 + GP4L3 + GP4L4 + GP4L5 + GP4L6 + GP4L7 + GP5L1 + GP5L2 + GP5L3 + GP5L4 + GP5L5 + GP5L6 + GP5L7 + GP6L1 + GP6L2 + GP6L3 + GP6L4 + GP6L5 + GP6L6 + GP6L7 + GP7L1 + GP7L2 + GP7L3 + GP7L4 + GP7L5 + GP7L6 + GP7L7 + GP8L1 + GP8L2 + GP8L3 + GP8L4 + GP8L5 + GP8L6 + GP8L7 + GP9L1 + GP9L2 + GP9L3 + GP9L4 + GP9L5 + GP9L6 + GP9L7 + GMC;
			Timeout=false;		
		}

			
		TotalMonedas = Tmonedas + Ganancia;
		monedas.text = TotalMonedas.ToString ();


				
			
				monedas.text = TotalMonedas.ToString ();
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A5stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A4stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A3stop");

				NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B5stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B4stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B3stop");

				NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C5stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C4stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C3stop");

				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP4L5stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP4L4stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP4L3stop");

				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP5L5stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP5L4stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP5L3stop");

				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP6L5stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP6L4stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP6L3stop");

				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP7L5stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP7L4stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP7L3stop");
	
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP8L5stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP8L4stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP8L3stop");

				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP8L5stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP8L4stop");
				NotificationCenter.DefaultCenter ().PostNotification (this, "ActiveP8L3stop");

				





	}

	void bringmonto1(){
		
		Tmonedas=1000;
		Inicio ();
	}
	
	void bringmonto2(){
		
		Tmonedas=3500;
		Inicio ();
	}
	void bringmonto3(){
		
		Tmonedas=6000;
		Inicio ();
	}
	void bringmonto4(){
		
		Tmonedas=500;
		Inicio ();
	}

// Update is called once per frame


	void Update () {

	
	}


	void CilindrosDetenidos(){
		Inicio ();

	}
	void Actualizar(){

		ApuestaMonedas = monto;
		ApuestaD = ApuestaMonedas / PL;
		Tmonedas += Ganancia;
		Ganancia = 0;
		//------Payline1--------
		GA1 = 0;
		GA2 = 0;
		GA3 = 0;
		GA4 = 0;
		GA5 = 0;
		GA6 = 0;
		GA7 = 0;
		//------Payline2--------
		GB1 = 0;
		GB2 = 0;
		GB3 = 0;
		GB4 = 0;
		GB5 = 0;
		GB6 = 0;
		GB7 = 0;
		//------Payline3--------
		GC1 = 0;
		GC2 = 0;
		GC3 = 0;
		GC4 = 0;
		GC5 = 0;
		GC6 = 0;
		GC7 = 0;
		//------Payline4--------
		GP4L1 = 0;
		GP4L2 = 0;
		GP4L3 = 0;
		GP4L4 = 0;
		GP4L5 = 0;
		GP4L6 = 0;
		GP4L7 = 0;
		//--------Payline5------
		GP5L1 = 0;
		GP5L2 = 0;
		GP5L3 = 0;
		GP5L4 = 0;
		GP5L5 = 0;
		GP5L6 = 0;
		GP5L7 = 0;
		//--------Payline6------
		GP6L1 = 0;
		GP6L2 = 0;
		GP6L3 = 0;
		GP6L4 = 0;
		GP6L5 = 0;
		GP6L6 = 0;
		GP6L7 = 0;
		//--------Payline7------
		GP7L1 = 0;
		GP7L2 = 0;
		GP7L3 = 0;
		GP7L4 = 0;
		GP7L5 = 0;
		GP7L6 = 0;
		GP7L7 = 0;
		//--------Payline8------
		GP8L1 = 0;
		GP8L2 = 0;
		GP8L3 = 0;
		GP8L4 = 0;
		GP8L5 = 0;
		GP8L6 = 0;
		GP8L7 = 0;
		//--------Payline9------
		GP9L1 = 0;
		GP9L2 = 0;
		GP9L3 = 0;
		GP9L4 = 0;
		GP9L5 = 0;
		GP9L6 = 0;
		GP9L7 = 0;
		//--------------

		win.text = Ganancia.ToString ();
		//if (montoPL <0){
		//	montoPL=0;
		//}
		if (Tmonedas <0){
			Tmonedas=0;

		}
				apuesta.text = monto.ToString ();
		monedas.text = Tmonedas.ToString ();

		}
//---------------------------------1---------------------------------
	void Figura1A5 (){

		GA1 = ApuestaD * 40;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A5");
		Invoke ("Inicio", 1.00f);		
	}

//----------------------------------------------------------------------------------
	void Figura1A4 (){

		GA1 = ApuestaD * 10;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A4");
		Invoke ("Inicio", 1.00f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1A3 (){

		GA1 = ApuestaD * 2;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A3");
		Invoke ("Inicio", 1.00f);	
	}
	//----------------------------------------------------------------------------------

//---------------------------------2---------------------------------
	void Figura2A5 (){
		
		GA2 = ApuestaD * 100;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2A4 (){
		
		GA2 = ApuestaD * 25;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2A3 (){
		
		GA2 = ApuestaD * 5;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A3");
		Invoke ("Inicio", 1.10f);	
	}
	//-----------------------------------------3-----------------------------------------

	void Figura3A5 (){
		
		GA3 = ApuestaD * 200;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3A4 (){
		
		GA3 = ApuestaD * 50;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3A3 (){
		
		GA3 = ApuestaD * 10;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A3");
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------4--------------------------------------------------

	void Figura4A5 (){
		
		GA4 = ApuestaD * 300;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4A4 (){
		
		GA4 = ApuestaD * 75;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4A3 (){
		
		GA4 = ApuestaD * 15;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A3");
		Invoke ("Inicio", 1.10f);	
	}
	//-------------------------------------5---------------------------------------------
	void Figura5A5 (){
		
		GA5 = ApuestaD * 400;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5A4 (){
		
		GA5 = ApuestaD * 100;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5A3 (){
		
		GA5 = ApuestaD * 20;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A3");
		Invoke ("Inicio", 1.10f);	
	}
//---------------------------------6----------------------------------------

	void Figura6A5 (){
	
		GA6 = ApuestaD * 500;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6A4 (){
		
		GA6 = ApuestaD * 200;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6A3 (){
		
		GA6 = ApuestaD * 30;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A3");
		Invoke ("Inicio", 1.10f);	
	}
//--------------------------------------------7---------------------------------

	void Figura7A5 (){
		
		GA7 = ApuestaD * 1000;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7A4 (){
		
		GA7 = ApuestaD * 300;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7A3 (){
		
		GA7 = ApuestaD * 40;
		BPL1.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL1A3");
		Invoke ("Inicio", 1.10f);	
	}

//...............................PAYLINE 2................................................

	//---------------------------------1---------------------------------
	void Figura1B5 (){
		
		GB1 = ApuestaD * 40;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1B4 (){
		
		GB1 = ApuestaD * 10;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1B3 (){
		
		GB1 = ApuestaD * 2;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B3");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	
	//---------------------------------2---------------------------------
	void Figura2B5 (){
		
		GB2 = ApuestaD * 100;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2B4 (){
		
		GB2 = ApuestaD * 25;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2B3 (){
		
		GB2 = ApuestaD * 5;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B3");
		Invoke ("Inicio", 1.10f);	
	}
	//-----------------------------------------3-----------------------------------------
	
	void Figura3B5 (){
		
		GB3 = ApuestaD * 200;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3B4 (){
		
		GB3 = ApuestaD * 50;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3B3 (){
		
		GB3 = ApuestaD * 10;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B3");
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------4--------------------------------------------------
	
	void Figura4B5 (){
		
		GB4 = ApuestaD * 300;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4B4 (){
		
		GB4 = ApuestaD * 75;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4B3 (){
		
		GB4 = ApuestaD * 15;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B3");
		Invoke ("Inicio", 1.10f);	
	}
	//-------------------------------------5---------------------------------------------
	void Figura5B5 (){
		
		GB5 = ApuestaD * 400;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5B4 (){
		
		GB5 = ApuestaD * 100;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5B3 (){
		
		GB5 = ApuestaD * 20;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B3");
		Invoke ("Inicio", 1.10f);	
	}
	//---------------------------------6----------------------------------------
	
	void Figura6B5 (){
		
		GB6 = ApuestaD * 500;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6B4 (){
		
		GB6 = ApuestaD * 200;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6B3 (){
		
		GB6 = ApuestaD * 30;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B3");
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------------------7---------------------------------
	
	void Figura7B5 (){
		
		GB7 = ApuestaD * 1000;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7B4 (){
		
		GB7 = ApuestaD * 300;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7B3 (){
		
		GB7 = ApuestaD * 40;
		BPL2.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL2B3");
		Invoke ("Inicio", 1.10f);	
	}

//............................PAYLINE 3................................................

	//---------------------------------1---------------------------------
	void Figura1C5 (){
		
		GC1 = ApuestaD * 40;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1C4 (){
		
		GC1 = ApuestaD * 10;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1C3 (){
		
		GC1 = ApuestaD * 2;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C3");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	
	//---------------------------------2---------------------------------
	void Figura2C5 (){
		
		GC2 = ApuestaD * 100;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2C4 (){
		
		GC2 = ApuestaD * 25;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C4");
		Invoke ("Inicio", 1.10f);	

	}
	//----------------------------------------------------------------------------------
	void Figura2C3 (){
		
		GC2 = ApuestaD * 5;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C3");
		Invoke ("Inicio", 1.10f);	
	}
	//-----------------------------------------3-----------------------------------------
	
	void Figura3C5 (){
		
		GC3 = ApuestaD * 200;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3C4 (){
		
		GC3 = ApuestaD * 50;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3C3 (){
		
		GC3 = ApuestaD * 10;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C3");
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------4--------------------------------------------------
	
	void Figura4C5 (){
		
		GC4 = ApuestaD * 300;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4C4 (){
		
		GC4 = ApuestaD * 75;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4C3 (){
		
		GC4 = ApuestaD * 15;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C3");
		Invoke ("Inicio", 1.10f);	
	}
	//-------------------------------------5---------------------------------------------
	void Figura5C5 (){
		
		GC5 = ApuestaD * 400;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5C4 (){
		
		GC5 = ApuestaD * 100;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5C3 (){
		
		GC5 = ApuestaD * 20;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C3");
		Invoke ("Inicio", 1.10f);	
	}
	//---------------------------------6----------------------------------------
	
	void Figura6C5 (){
		GC6 = ApuestaD * 500;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6C4 (){
		
		GC6 = ApuestaD * 200;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6C3 (){
		
		GC6 = ApuestaD * 30;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C3");
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------------------7---------------------------------
	
	void Figura7C5 (){
		
		GC7 = ApuestaD * 1000;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C5");
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7C4 (){
		
		GC7 = ApuestaD * 300;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C4");
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7C3 (){
		
		GC7 = ApuestaD * 40;
		BPL3.SetActive(true);
		NotificationCenter.DefaultCenter ().PostNotification (this, "ActivePL3C3");
		Invoke ("Inicio", 1.10f);	
	}
	//............................PAYLINE 4................................................
	
	//---------------------------------1---------------------------------
	void Figura1P4L5 (){
		
		GP4L1 = ApuestaD * 40;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P4L4 (){
		
		GP4L1 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P4L3 (){
		
		GP4L1 = ApuestaD * 2;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	
	//---------------------------------2---------------------------------
	void Figura2P4L5 (){
		
		GP4L2 = ApuestaD * 100;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P4L4 (){
		
		GP4L2 = ApuestaD * 25;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P4L3 (){
		
		GP4L2 = ApuestaD * 5;
		Invoke ("Inicio", 1.10f);	
	}
	//-----------------------------------------3-----------------------------------------
	
	void Figura3P4L5 (){
		
		GP4L3 = ApuestaD * 200;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P4L4 (){
		
		GP4L3 = ApuestaD * 50;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P4L3 (){
		
		GP4L3 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------4--------------------------------------------------
	
	void Figura4P4L5 (){
		
		GP4L4 = ApuestaD * 300;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P4L4 (){
		
		GP4L4 = ApuestaD * 75;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P4L3 (){
		
		GP4L4 = ApuestaD * 15;
		Invoke ("Inicio", 1.10f);	
	}
	//-------------------------------------5---------------------------------------------
	void Figura5P4L5 (){
		
		GP4L5 = ApuestaD * 400;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P4L4 (){
		
		GP4L5 = ApuestaD * 100;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P4L3 (){
		
		GP4L5 = ApuestaD * 20;
		Invoke ("Inicio", 1.10f);	
	}
	//---------------------------------6----------------------------------------
	
	void Figura6P4L5 (){
		GP4L6 = ApuestaD * 500;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P4L4 (){
		
		GP4L6 = ApuestaD * 200;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P4L3 (){
		
		GP4L6 = ApuestaD * 30;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------------------7---------------------------------
	
	void Figura7P4L5 (){
		
		GP4L7 = ApuestaD * 1000;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P4L4 (){
		
		GP4L7 = ApuestaD * 300;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P4L3 (){
		
		GP4L7 = ApuestaD * 40;
		Invoke ("Inicio", 1.10f);	
	}
	//............................PAYLINE 5................................................
	
	//---------------------------------1---------------------------------
	void Figura1P5L5 (){
		
		GP5L1 = ApuestaD * 40;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P5L4 (){
		
		GP5L1 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P5L3 (){
		
		GP5L1 = ApuestaD * 2;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	
	//---------------------------------2---------------------------------
	void Figura2P5L5 (){
		
		GP5L2 = ApuestaD * 100;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P5L4 (){
		
		GP5L2 = ApuestaD * 25;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P5L3 (){
		
		GP5L2 = ApuestaD * 5;
		Invoke ("Inicio", 1.10f);	
	}
	//-----------------------------------------3-----------------------------------------
	
	void Figura3P5L5 (){
		
		GP5L3 = ApuestaD * 200;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P5L4 (){
		
		GP5L3 = ApuestaD * 50;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P5L3 (){
		
		GP5L3 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------4--------------------------------------------------
	
	void Figura4P5L5 (){
		
		GP5L4 = ApuestaD * 300;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P5L4 (){
		
		GP5L4 = ApuestaD * 75;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P5L3 (){
		
		GP5L4 = ApuestaD * 15;
		Invoke ("Inicio", 1.10f);	
	}
	//-------------------------------------5---------------------------------------------
	void Figura5P5L5 (){
		
		GP5L5 = ApuestaD * 400;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P5L4 (){
		
		GP5L5 = ApuestaD * 100;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P5L3 (){
		
		GP5L5 = ApuestaD * 20;
		Invoke ("Inicio", 1.10f);	
	}
	//---------------------------------6----------------------------------------
	
	void Figura6P5L5 (){
		GP5L6 = ApuestaD * 500;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P5L4 (){
		
		GP5L6 = ApuestaD * 200;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P5L3 (){
		
		GP5L6 = ApuestaD * 30;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------------------7---------------------------------
	
	void Figura7P5L5 (){
		
		GP5L7 = ApuestaD * 1000;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P5L4 (){
		
		GP5L7 = ApuestaD * 300;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P5L3 (){
		
		GP5L7 = ApuestaD * 40;
		Invoke ("Inicio", 1.10f);	
	}
//......................................................................

	//............................PAYLINE 6................................................
	
	//---------------------------------1---------------------------------
	void Figura1P6L5 (){
		
		GP6L1 = ApuestaD * 40;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P6L4 (){
		
		GP6L1 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P6L3 (){
		
		GP6L1 = ApuestaD * 2;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	
	//---------------------------------2---------------------------------
	void Figura2P6L5 (){
		
		GP6L2 = ApuestaD * 100;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P6L4 (){
		
		GP6L2 = ApuestaD * 25;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P6L3 (){
		
		GP6L2 = ApuestaD * 5;
		Invoke ("Inicio", 1.10f);	
	}
	//-----------------------------------------3-----------------------------------------
	
	void Figura3P6L5 (){
		
		GP6L3 = ApuestaD * 200;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P6L4 (){
		
		GP6L3 = ApuestaD * 50;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P6L3 (){
		
		GP6L3 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------4--------------------------------------------------
	
	void Figura4P6L5 (){
		
		GP6L4 = ApuestaD * 300;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P6L4 (){
		
		GP6L4 = ApuestaD * 75;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P6L3 (){
		
		GP6L4 = ApuestaD * 15;
		Invoke ("Inicio", 1.10f);	
	}
	//-------------------------------------5---------------------------------------------
	void Figura5P6L5 (){
		
		GP6L5 = ApuestaD * 400;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P6L4 (){
		
		GP6L5 = ApuestaD * 100;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P6L3 (){
		
		GP6L5 = ApuestaD * 20;
		Invoke ("Inicio", 1.10f);	
	}
	//---------------------------------6----------------------------------------
	
	void Figura6P6L5 (){
		GP6L6 = ApuestaD * 500;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P6L4 (){
		
		GP6L6 = ApuestaD * 200;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P6L3 (){
		
		GP6L6 = ApuestaD * 30;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------------------7---------------------------------
	
	void Figura7P6L5 (){
		
		GP6L7 = ApuestaD * 1000;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P6L4 (){
		
		GP6L7 = ApuestaD * 300;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P6L3 (){
		
		GP6L7 = ApuestaD * 40;
		Invoke ("Inicio", 1.10f);	
	}

	//............................PAYLINE 7................................................
	
	//---------------------------------1---------------------------------
	void Figura1P7L5 (){
		
		GP7L1 = ApuestaD * 40;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P7L4 (){
		
		GP7L1 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P7L3 (){
		
		GP7L1 = ApuestaD * 2;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	
	//---------------------------------2---------------------------------
	void Figura2P7L5 (){
		
		GP7L2 = ApuestaD * 100;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P7L4 (){
		
		GP7L2 = ApuestaD * 25;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P7L3 (){
		
		GP7L2 = ApuestaD * 5;
		Invoke ("Inicio", 1.10f);	
	}
	//-----------------------------------------3-----------------------------------------
	
	void Figura3P7L5 (){
		
		GP7L3 = ApuestaD * 200;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P7L4 (){
		
		GP7L3 = ApuestaD * 50;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P7L3 (){
		
		GP7L3 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------4--------------------------------------------------
	
	void Figura4P7L5 (){
		
		GP7L4 = ApuestaD * 300;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P7L4 (){
		
		GP7L4 = ApuestaD * 75;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P7L3 (){
		
		GP7L4 = ApuestaD * 15;
		Invoke ("Inicio", 1.10f);	
	}
	//-------------------------------------5---------------------------------------------
	void Figura5P7L5 (){
		
		GP7L5 = ApuestaD * 400;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P7L4 (){
		
		GP7L5 = ApuestaD * 100;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P7L3 (){
		
		GP7L5 = ApuestaD * 20;
		Invoke ("Inicio", 1.10f);	
	}
	//---------------------------------6----------------------------------------
	
	void Figura6P7L5 (){
		GP7L6 = ApuestaD * 500;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P7L4 (){
		
		GP7L6 = ApuestaD * 200;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P7L3 (){
		
		GP7L6 = ApuestaD * 30;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------------------7---------------------------------
	
	void Figura7P7L5 (){
		
		GP7L7 = ApuestaD * 1000;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P7L4 (){
		
		GP7L7 = ApuestaD * 300;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P7L3 (){
		
		GP7L7 = ApuestaD * 40;
		Invoke ("Inicio", 1.10f);	
	}

	//............................PAYLINE 8................................................
	
	//---------------------------------1---------------------------------
	void Figura1P8L5 (){
		
		GP8L1 = ApuestaD * 40;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P8L4 (){
		
		GP8L1 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P8L3 (){
		
		GP8L1 = ApuestaD * 2;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	
	//---------------------------------2---------------------------------
	void Figura2P8L5 (){
		
		GP8L2 = ApuestaD * 100;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P8L4 (){
		
		GP8L2 = ApuestaD * 25;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P8L3 (){
		
		GP8L2 = ApuestaD * 5;
		Invoke ("Inicio", 1.10f);	
	}
	//-----------------------------------------3-----------------------------------------
	
	void Figura3P8L5 (){
		
		GP8L3 = ApuestaD * 200;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P8L4 (){
		
		GP8L3 = ApuestaD * 50;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P8L3 (){
		
		GP8L3 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------4--------------------------------------------------
	
	void Figura4P8L5 (){
		
		GP8L4 = ApuestaD * 300;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P8L4 (){
		
		GP8L4 = ApuestaD * 75;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P8L3 (){
		
		GP8L4 = ApuestaD * 15;
		Invoke ("Inicio", 1.10f);	
	}
	//-------------------------------------5---------------------------------------------
	void Figura5P8L5 (){
		
		GP8L5 = ApuestaD * 400;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P8L4 (){
		
		GP8L5 = ApuestaD * 100;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P8L3 (){
		
		GP8L5 = ApuestaD * 20;
		Invoke ("Inicio", 1.10f);	
	}
	//---------------------------------6----------------------------------------
	
	void Figura6P8L5 (){
		GP8L6 = ApuestaD * 500;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P8L4 (){
		
		GP8L6 = ApuestaD * 200;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P8L3 (){
		
		GP8L6 = ApuestaD * 30;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------------------7---------------------------------
	
	void Figura7P8L5 (){
		
		GP8L7 = ApuestaD * 1000;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P8L4 (){
		
		GP8L7 = monto * 300;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P8L3 (){
		
		GP8L7 = ApuestaD * 40;
		Invoke ("Inicio", 1.10f);	
	}

	//............................PAYLINE 9......................................................
	
	//---------------------------------1---------------------------------
	void Figura1P9L5 (){
		
		GP9L1 = ApuestaD * 40;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P9L4 (){
		
		GP9L1 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura1P9L3 (){
		
		GP9L1 = ApuestaD * 2;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	
	//---------------------------------2---------------------------------
	void Figura2P9L5 (){
		
		GP9L2 = ApuestaD * 100;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P9L4 (){
		
		GP9L2 = ApuestaD * 25;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura2P9L3 (){
		
		GP9L2 = ApuestaD * 5;
		Invoke ("Inicio", 1.10f);	
	}
	//-----------------------------------------3-----------------------------------------
	
	void Figura3P9L5 (){
		
		GP9L3 = ApuestaD * 200;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P9L4 (){
		
		GP9L3 = ApuestaD * 50;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura3P9L3 (){
		
		GP9L3 = ApuestaD * 10;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------4--------------------------------------------------
	
	void Figura4P9L5 (){
		
		GP9L4 = ApuestaD * 300;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P9L4 (){
		
		GP9L4 = ApuestaD * 75;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura4P9L3 (){
		
		GP9L4 = ApuestaD * 15;
		Invoke ("Inicio", 1.10f);	
	}
	//-------------------------------------5---------------------------------------------
	void Figura5P9L5 (){
		
		GP9L5 = ApuestaD * 400;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P9L4 (){
		
		GP9L5 = ApuestaD * 100;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura5P9L3 (){
		
		GP9L5 = ApuestaD * 20;
		Invoke ("Inicio", 1.10f);	
	}
	//---------------------------------6----------------------------------------
	
	void Figura6P9L5 (){
		GP9L6 = ApuestaD * 500;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P9L4 (){
		
		GP9L6 = ApuestaD * 200;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura6P9L3 (){
		
		GP9L6 = ApuestaD * 30;
		Invoke ("Inicio", 1.10f);	
	}
	//--------------------------------------------7---------------------------------
	
	void Figura7P9L5 (){
		
		GP9L7 = ApuestaD * 1000;
		Invoke ("Inicio", 1.30f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P9L4 (){
		
		GP9L7 = ApuestaD * 300;
		Invoke ("Inicio", 1.10f);	
	}
	//----------------------------------------------------------------------------------
	void Figura7P9L3 (){
		
		GP9L7 = ApuestaD * 40;
		Invoke ("Inicio", 1.10f);	
	}


}
