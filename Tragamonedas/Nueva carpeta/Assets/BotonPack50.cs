using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Soomla;
using Soomla.Store;

namespace Soomla.Store.Example {
public class BotonPack50 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown(){
			StoreInventory.BuyItem (SlotStore.FIFTYCURRENCY_PACK_PRODUCT_ID);
	}
	// Update is called once per frame
	void Update () {
	
	}
}

}