using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Soomla;



	// Use this for initialization
	namespace Soomla.Store.Example {
		
		/// <summary>
		/// This class contains functions that initialize the game and that display the different screens of the game.
		/// </summary>
		public class SoomlaCall : MonoBehaviour {
			

			void Start () {
				
			SoomlaStore.Initialize(new SlotStore());

			}

	// Update is called once per frame
	void Update () {
	
	}
}
}
