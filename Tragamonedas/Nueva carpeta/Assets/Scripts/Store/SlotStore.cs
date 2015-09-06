using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Soomla.Store;

namespace Soomla.Store.Example {
	
	/// <summary>
	/// This class defines our game's economy, which includes virtual goods, virtual currencies
	/// and currency packs, virtual categories
	/// </summary>
	public class SlotStore : IStoreAssets{
		
		/// <summary>
		/// see parent.
		/// </summary>
		public int GetVersion() {
			return 0;
		}
		
		/// <summary>
		/// see parent.
		/// </summary>
		public VirtualCurrency[] GetCurrencies() {
			return new VirtualCurrency[]{SLOT_CURRENCY_ITEM};
		}
		
		/// <summary>
		/// see parent.
		/// </summary>
		public VirtualGood[] GetGoods() {
			return new VirtualGood[] {NO_ADS_LTVG};
		}
		
		/// <summary>
		/// see parent.
		/// </summary>
		public VirtualCurrencyPack[] GetCurrencyPacks() {
			return new VirtualCurrencyPack[] {FIFTYCURRENCY_PACK_PRODUCT};
		}
		
		/// <summary>
		/// see parent.
		/// </summary>
		public VirtualCategory[] GetCategories() {
			return new VirtualCategory[]{};
		}

		
		/** Static Final Members **/



		public const string SLOT_CURRENCY_ITEM_ID      = "currency.test_1";
		
		//public const string TENMUFF_PACK_PRODUCT_ID      = "android.test.refunded";
		
		public const string FIFTYCURRENCY_PACK_PRODUCT_ID    = "currency.pack.test_50";

			public const string NO_ADS_LIFETIME_PRODUCT_ID = "no_ads";
		
	
		/** Virtual Currencies **/
		
		public static VirtualCurrency SLOT_CURRENCY_ITEM = new VirtualCurrency(
			"Coins",										// name
			"One coin Slot machine",												// description
			SLOT_CURRENCY_ITEM_ID							// item id
			);
		
		
		/** Virtual Currency Packs **/

		public static VirtualCurrencyPack FIFTYCURRENCY_PACK_PRODUCT = new VirtualCurrencyPack(
			"50 coins",                                   // name
			"Test cancellation of an item",                 // description
			"coins_50",                                   // item id
			50,                                             // number of currencies in the pack
			SLOT_CURRENCY_ITEM_ID,                        // the currency associated with this pack
			new PurchaseWithMarket(FIFTYCURRENCY_PACK_PRODUCT_ID, 1.99)
			);

		/*public static VirtualCurrencyPack TENMUFF_PACK = new VirtualCurrencyPack(
			"10 Muffins",                                   // name
			"Test refund of an item",                       // description
			"muffins_10",                                   // item id
			10,												// number of currencies in the pack
			MUFFIN_CURRENCY_ITEM_ID,                        // the currency associated with this pack
			new PurchaseWithMarket(TENMUFF_PACK_PRODUCT_ID, 0.99)
			);
		

		
		public static VirtualCurrencyPack FOURHUNDMUFF_PACK = new VirtualCurrencyPack(
			"400 Muffins",                                  // name
			"Test purchase of an item",                 	// description
			"muffins_400",                                  // item id
			400,                                            // number of currencies in the pack
			MUFFIN_CURRENCY_ITEM_ID,                        // the currency associated with this pack
			new PurchaseWithMarket(FOURHUNDMUFF_PACK_PRODUCT_ID, 4.99)
			);
		
		public static VirtualCurrencyPack THOUSANDMUFF_PACK = new VirtualCurrencyPack(
			"1000 Muffins",                                 // name
			"Test item unavailable",                 		// description
			"muffins_1000",                                 // item id
			1000,                                           // number of currencies in the pack
			MUFFIN_CURRENCY_ITEM_ID,                        // the currency associated with this pack
			new PurchaseWithMarket(THOUSANDMUFF_PACK_PRODUCT_ID, 8.99)
			);
		
		/** Virtual Goods 
		
		public static VirtualGood MUFFINCAKE_GOOD = new SingleUseVG(
			"Fruit Cake",                                       		// name
			"Customers buy a double portion on each purchase of this cake", // description
			"fruit_cake",                                       		// item id
			new PurchaseWithVirtualItem(MUFFIN_CURRENCY_ITEM_ID, 225)); // the way this virtual good is purchased
		
		public static VirtualGood PAVLOVA_GOOD = new SingleUseVG(
			"Pavlova",                                         			// name
			"Gives customers a sugar rush and they call their friends", // description
			"pavlova",                                          		// item id
			new PurchaseWithVirtualItem(MUFFIN_CURRENCY_ITEM_ID, 175)); // the way this virtual good is purchased
		
		public static VirtualGood CHOCLATECAKE_GOOD = new SingleUseVG(
			"Chocolate Cake",                                   		// name
			"A classic cake to maximize customer satisfaction",	 		// description
			"chocolate_cake",                                   		// item id
			new PurchaseWithVirtualItem(MUFFIN_CURRENCY_ITEM_ID, 250)); // the way this virtual good is purchased
		
		
		public static VirtualGood CREAMCUP_GOOD = new SingleUseVG(
			"Cream Cup",                                        		// name
			"Increase bakery reputation with this original pastry",   	// description
			"cream_cup",                                        		// item id
			new PurchaseWithVirtualItem(MUFFIN_CURRENCY_ITEM_ID, 50));  // the way this virtual good is purchased
		
		
		/** Virtual Categories 
		// The muffin rush theme doesn't support categories, so we just put everything under a general category.
		public static VirtualCategory GENERAL_CATEGORY = new VirtualCategory(
			"General", new List<string>(new string[] { MUFFINCAKE_ITEM_ID, PAVLOVA_ITEM_ID, CHOCLATECAKE_ITEM_ID, CREAMCUP_ITEM_ID })
			);
		
		**/
		/** LifeTimeVGs **/
		// Note: create non-consumable items using LifeTimeVG with PuchaseType of PurchaseWithMarket
		public static VirtualGood NO_ADS_LTVG = new LifetimeVG(
			"No Ads", 														// name
			"No More Ads!",				 									// description
			"no_ads",														// item id
			new PurchaseWithMarket(NO_ADS_LIFETIME_PRODUCT_ID, 0.99));	// the way this virtual good is purchased
	}



}
