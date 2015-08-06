using UnityEngine;
using System.Collections;

public class Payline9 : MonoBehaviour {

	// Aqui se declaran el valor de las condiciones por figuras
	// Solo lectura de Payline9
	private int condicionF1P9L3= 0;
	private int condicionF1P9L4= 0;
	private int condicionF1P9L5= 0;
	
	private int condicionF2P9L3= 0;
	private int condicionF2P9L4= 0;
	private int condicionF2P9L5= 0;
	
	private int condicionF3P9L3= 0;
	private int condicionF3P9L4= 0;
	private int condicionF3P9L5= 0;
	
	private int condicionF4P9L3= 0;
	private int condicionF4P9L4= 0;
	private int condicionF4P9L5= 0;
	
	private int condicionF5P9L3= 0;
	private int condicionF5P9L4= 0;
	private int condicionF5P9L5= 0;
	
	private int condicionF6P9L3= 0;
	private int condicionF6P9L4= 0;
	private int condicionF6P9L5= 0;
	
	private int condicionF7P9L3= 0;
	private int condicionF7P9L4= 0;
	private int condicionF7P9L5= 0;


	//===========Experiencia en Linea de pago 9=============
	public int P9L5Exp= 0;
	public int P9L4Exp= 0;
	public int P9L3Exp= 0;
	//======================================================

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax5");
		NotificationCenter.DefaultCenter ().AddObserver (this,"CilindrosDetenidos");
		//recibe notificaciones de las figuras
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B5");
		
	}

	void CilindrosDetenidos(){
		Inicio ();
	}
	//--------------------Suma a la Var Condicion-------------------------------------------
	//..................f1.......................
	void F1C1(){
		condicionF1P9L3 += 1;
		condicionF1P9L3 += 1;
		condicionF1P9L3 += 1;
		
	}
	void F1C2(){
		condicionF1P9L3 += 1;
		condicionF1P9L3 += 1;
		condicionF1P9L3 += 1;
	}
	void F1B3(){
		condicionF1P9L3 += 1;
		condicionF1P9L3 += 1;
		condicionF1P9L3 += 1;
	}
	void F1A4(){
		condicionF1P9L3 -= 1;
		condicionF1P9L3 += 1;
		condicionF1P9L3 += 1;
	}
	void F1B5(){
		condicionF1P9L3 -= 1;
		condicionF1P9L3 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f2.......................
	void F2C1(){
		condicionF2P9L3 += 1;
		condicionF2P9L3 += 1;
		condicionF2P9L3 += 1;
	}
	void F2C2(){
		condicionF2P9L3 += 1;
		condicionF2P9L3 += 1;
		condicionF2P9L3 += 1;
	}
	void F2B3(){
		condicionF2P9L3 += 1;
		condicionF2P9L3 += 1;
		condicionF2P9L3 += 1;
	}
	void F2A4(){
		condicionF2P9L3 -= 1;
		condicionF2P9L3 += 1;
		condicionF2P9L3 += 1;
	}
	void F2B5(){
		condicionF2P9L3 -= 1;
		condicionF2P9L3 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f3.......................
	void F3C1(){
		condicionF3P9L3 += 1;
		condicionF3P9L3 += 1;
		condicionF3P9L3 += 1;
	}
	void F3C2(){
		condicionF3P9L3 += 1;
		condicionF3P9L3 += 1;
		condicionF3P9L3 += 1;
	}
	void F3B3(){
		condicionF3P9L3 += 1;
		condicionF3P9L3 += 1;
		condicionF3P9L3 += 1;
	}
	void F3A4(){
		condicionF3P9L3 -= 1;
		condicionF3P9L3 += 1;
		condicionF3P9L3 += 1;
	}
	void F3B5(){
		condicionF3P9L3 -= 1;
		condicionF3P9L3 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f4.......................
	void F4C1(){
		condicionF4P9L3 += 1;
		condicionF4P9L3 += 1;
		condicionF4P9L3 += 1;
	}
	void F4C2(){
		condicionF4P9L3 += 1;
		condicionF4P9L3 += 1;
		condicionF4P9L3 += 1;
	}
	void F4B3(){
		condicionF4P9L3 += 1;
		condicionF4P9L3 += 1;
		condicionF4P9L3 += 1;
	}
	void F4A4(){
		condicionF4P9L3 -= 1;
		condicionF4P9L3 += 1;
		condicionF4P9L3 += 1;
	}
	void F4B5(){
		condicionF4P9L3 -= 1;
		condicionF4P9L3 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f5.......................
	void F5C1(){
		condicionF5P9L3 += 1;
		condicionF5P9L3 += 1;
		condicionF5P9L3 += 1;
	}
	void F5C2(){
		condicionF5P9L3 += 1;
		condicionF5P9L3 += 1;
		condicionF5P9L3 += 1;
	}
	void F5B3(){
		condicionF5P9L3 += 1;
		condicionF5P9L3 += 1;
		condicionF5P9L3 += 1;
	}
	void F5A4(){
		condicionF5P9L3 -= 1;
		condicionF5P9L3 += 1;
		condicionF5P9L3 += 1;
	}
	void F5B5(){
		condicionF5P9L3 -= 1;
		condicionF5P9L3 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f6.......................
	void F6C1(){
		condicionF6P9L3 += 1;
		condicionF6P9L3 += 1;
		condicionF6P9L3 += 1;
	}
	void F6C2(){
		condicionF6P9L3 += 1;
		condicionF6P9L3 += 1;
		condicionF6P9L3 += 1;
	}
	void F6B3(){
		condicionF6P9L3 += 1;
		condicionF6P9L3 += 1;
		condicionF6P9L3 += 1;
	}
	void F6A4(){
		condicionF6P9L3 -= 1;
		condicionF6P9L3 += 1;
		condicionF6P9L3 += 1;
	}
	void F6B5(){
		condicionF6P9L3 -= 1;
		condicionF6P9L3 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f7.......................
	void F7C1(){
		condicionF7P9L3 += 1;
		condicionF7P9L3 += 1;
		condicionF7P9L3 += 1;
	}
	void F7C2(){
		condicionF7P9L3 += 1;
		condicionF7P9L3 += 1;
		condicionF7P9L3 += 1;
	}
	void F7B3(){
		condicionF7P9L3 += 1;
		condicionF7P9L3 += 1;
		condicionF7P9L3 += 1;
	}
	void F7A4(){
		condicionF7P9L3 -= 1;
		condicionF7P9L3 += 1;
		condicionF7P9L3 += 1;
	}
	void F7B5(){
		condicionF7P9L3 -= 1;
		condicionF7P9L3 += 1;
	}
	//-----------------------------------------------------------------------------
	
	// Update is called once per frame
	
	//--------------------------------------Condiciones-----------------------------
	//---------------------------------------------1-------------------------------------------
	void Update () {
		}
	void Parallax5(){

		if (condicionF1P9L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura1P9L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L5exp", P9L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF1P9L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1P9L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L4exp", P9L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF1P9L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1P9L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L3exp", P9L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------2-----------------------------------------------
		
		if (condicionF2P9L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura2P9L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L5exp", P9L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF2P9L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2P9L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L4exp", P9L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF2P9L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2P9L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L3exp", P9L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------3---------------------------------------------
		
		if (condicionF3P9L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura3P9L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L5exp", P9L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF3P9L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3P9L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L4exp", P9L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF3P9L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3P9L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L3exp", P9L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------4---------------------------------------------
		
		if (condicionF4P9L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura4P9L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L5exp", P9L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF4P9L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4P9L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L4exp", P9L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF4P9L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4P9L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L3exp", P9L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------5-----------------------------------------------
		
		if (condicionF5P9L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura5P9L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L5exp", P9L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF5P9L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5P9L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L4exp", P9L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF5P9L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5P9L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L3exp", P9L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//---------------------------------------------6-------------------------------------------
		
		if (condicionF6P9L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura6P9L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L5exp", P9L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF6P9L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6P9L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L4exp", P9L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF6P9L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6P9L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L3exp", P9L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//------------------------------------------7----------------------------------------------
		
		if (condicionF7P9L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura7P9L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L5exp", P9L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF7P9L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7P9L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L4exp", P9L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF7P9L4 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7P9L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P9L3exp", P9L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	}
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------
	
	void Inicio(){
		condicionF1P9L3 = 0;
		condicionF1P9L4 = 0;
		condicionF1P9L5 = 0;
		
		condicionF2P9L3 = 0;
		condicionF2P9L4 = 0;
		condicionF2P9L5 = 0;
		
		condicionF3P9L3 = 0;
		condicionF3P9L4 = 0;
		condicionF3P9L5 = 0;
		
		condicionF4P9L3 = 0;
		condicionF4P9L4 = 0;
		condicionF4P9L5 = 0;
		
		condicionF5P9L3 = 0;
		condicionF5P9L4 = 0;
		condicionF5P9L5 = 0;
		
		condicionF6P9L3 = 0;
		condicionF6P9L4 = 0;
		condicionF6P9L5 = 0;
		
		condicionF7P9L3 = 0;
		condicionF7P9L4 = 0;
		condicionF7P9L5 = 0;
	}
	
}