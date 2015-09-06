using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Soomla;
using Soomla.Store;



	// Use this for initialization
	namespace Soomla.Store.Example {
		
		/// <summary>
		/// This class contains functions that initialize the game and that display the different screens of the game.
		/// </summary>
		
		public class SoomlaCall : MonoBehaviour {


			void Start () {
			DontDestroyOnLoad(gameObject);

			StoreEvents.OnSoomlaStoreInitialized += onSoomlaStoreInitialized;	
			SoomlaStore.Initialize(new SlotStore());
			StoreEvents.OnMarketPurchase += onMarketPurchase;

			StoreEvents.OnItemPurchased += onItemPurchased;

			StoreEvents.OnMarketPurchaseStarted += onMarketPurchaseStarted;

			StoreEvents.OnItemPurchaseStarted += onItemPurchaseStarted;

			StoreEvents.OnMarketPurchaseCancelled += onMarketPurchaseCancelled;



			StoreEvents.OnUnexpectedStoreError += onUnexpectedStoreError;
			
			#if UNITY_ANDROID && !UNITY_EDITOR
			StoreEvents.OnIabServiceStarted += onIabServiceStarted;
			StoreEvents.OnIabServiceStopped += onIabServiceStopped;
			#endif
		}

		public void onSoomlaStoreInitialized() {

		}
		/// <summary>
		/// Handles unexpected errors with error code.
		/// </summary>
		/// <param name="errorCode">The error code.</param>
		public void onUnexpectedStoreError(int errorCode) {
			SoomlaUtils.LogError ("ExampleEventHandler", "error with code: " + errorCode);
			
		}
		
		/// <summary>
		/// Handles a market purchase event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		/// <param name="purchaseToken">Purchase token.</param>
		public void onMarketPurchase(PurchasableVirtualItem pvi, string payload, Dictionary<string, string> extra) {
			
		}
		
		/// <summary>
		/// Handles a market refund event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		public void onMarketRefund(PurchasableVirtualItem pvi) {
			
		}
		
		/// <summary>
		/// Handles an item purchase event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		public void onItemPurchased(PurchasableVirtualItem pvi, string payload) {
			switch (pvi.ID) {
			case SlotStore.FIFTYCURRENCY_PACK_PRODUCT_ID:
				NotificationCenter.DefaultCenter().PostNotification(this, "pack50");
			break;
			}



		}
		
		/// <summary>
		/// Handles a good equipped event.
		/// </summary>
		/// <param name="good">Equippable virtual good.</param>
		public void onGoodEquipped(EquippableVG good) {
			
		}
		
		/// <summary>
		/// Handles a good unequipped event.
		/// </summary>
		/// <param name="good">Equippable virtual good.</param>
		public void onGoodUnequipped(EquippableVG good) {
			
		}
		
		/// <summary>
		/// Handles a good upgraded event.
		/// </summary>
		/// <param name="good">Virtual good that is being upgraded.</param>
		/// <param name="currentUpgrade">The current upgrade that the given virtual
		/// good is being upgraded to.</param>
		public void onGoodUpgrade(VirtualGood good, UpgradeVG currentUpgrade) {
			
		}
		
		/// <summary>
		/// Handles a billing supported event.
		/// </summary>
		public void onBillingSupported() {
			
		}
		
		/// <summary>
		/// Handles a billing NOT supported event.
		/// </summary>
		public void onBillingNotSupported() {
			
		}
		
		/// <summary>
		/// Handles a market purchase started event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		public void onMarketPurchaseStarted(PurchasableVirtualItem pvi) {
			
		}
		
		/// <summary>
		/// Handles an item purchase started event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		public void onItemPurchaseStarted(PurchasableVirtualItem pvi) {
			
		}
		
		/// <summary>
		/// Handles an item purchase cancelled event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		public void onMarketPurchaseCancelled(PurchasableVirtualItem pvi) {
			
		}
		
		/// <summary>
		/// Handles a currency balance changed event.
		/// </summary>
		/// <param name="virtualCurrency">Virtual currency whose balance has changed.</param>
		/// <param name="balance">Balance of the given virtual currency.</param>
		/// <param name="amountAdded">Amount added to the balance.</param>
		public void onCurrencyBalanceChanged(VirtualCurrency virtualCurrency, int balance, int amountAdded) {

		}
		
		/// <summary>
		/// Handles a good balance changed event.
		/// </summary>
		/// <param name="good">Virtual good whose balance has changed.</param>
		/// <param name="balance">Balance.</param>
		/// <param name="amountAdded">Amount added.</param>
		public void onGoodBalanceChanged(VirtualGood good, int balance, int amountAdded) {
			
		}
		
		/// <summary>
		/// Handles a restore Transactions process started event.
		/// </summary>
		public void onRestoreTransactionsStarted() {
			
		}
		
		/// <summary>
		/// Handles a restore transactions process finished event.
		/// </summary>
		/// <param name="success">If set to <c>true</c> success.</param>
		public void onRestoreTransactionsFinished(bool success) {
			
		}
		
		/// <summary>
		/// Handles a store controller initialized event.
		/// </summary>

		
		#if UNITY_ANDROID && !UNITY_EDITOR
		public void onIabServiceStarted() {
			
		}
		public void onIabServiceStopped() {
			
		}
		#endif
	}
}