using UnityEngine;
using System.Collections;
using System.Collections.Generic;


	namespace Soomla.Store.Example {
		
		/// <summary>
		/// This class defines our game's economy, which includes virtual goods, virtual currencies
		/// and currency packs, virtual categories
		/// </summary>
		public class SlotMachineStore : IStoreAssets{
			
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
			return new VirtualCurrency[]{NO_ADS_NONCONS};
			}
			
			/// <summary>
			/// see parent.
			/// </summary>
			public VirtualGood[] GetGoods() {
				return new VirtualGood[] {};
			}
			
			/// <summary>
			/// see parent.
			/// </summary>
			public VirtualCurrencyPack[] GetCurrencyPacks() {
			return new VirtualCurrencyPack[] {FIFTYMUFF_PACK};
			}
			
			/// <summary>
			/// see parent.
			/// </summary>
			public VirtualCategory[] GetCategories() {
				return new VirtualCategory[]{};
			}
			
			
		public NonConsumableItem[] GetNonConsumableItems(){
			return new NonConsumableItem[]{NO_ADS_NONCONS};
		}

		//DEclarar Item_ID

		public static string NO_ADS_NONCONS_PRODUCT_ID = "android.test.purchased";

		public static NonConsumableItem NO_ADS_NONCONS = new VirtualCurrency(
			"No Ads", // nombre
			"Esto es un producto", // descripcion
			"no_ads_item_id", // Item id
			new PurchaseWithMarket(new MarketItem(NO_ADS_NONCONS_PRODUCT_ID,0.99))
			);


	
	}
}
