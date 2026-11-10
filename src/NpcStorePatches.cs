using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace WOLAP
{
    [HarmonyPatch]
    internal class NpcStorePatches
    {
        [HarmonyPatch(typeof(NpcStore), "HandleBuySell")]
        [HarmonyPrefix]
        static bool HandleBuySellAPCheckPatch(NpcStore __instance)
        {
            NpcStoreItem npcStoreItem = NpcStoreItem.selected;
            if (npcStoreItem == null) return false;

            int invid = npcStoreItem.item.invid;
	        int iNpcStoreItem = -1;
	        bool fReselect = (npcStoreItem.item.quantity < 0 || npcStoreItem.item.quantity > 1) && npcStoreItem.item.isStackable;
            bool isStoreItem = npcStoreItem.isStoreItem;
            MItem item = npcStoreItem.item;
            Traverse traverse = Traverse.Create(__instance);

            if(isStoreItem){ //This now checks if the selected item is the shops item of if its an item in the players inventory, true = store item, false = player inv
                if (item.id != "archipelago_shopitem") return true;
                if (!MPlayer.instance.FTrySubtractMeat(npcStoreItem.meat))
                {
                    WestOfLoathing.instance.state_machine.Push(new ConfirmState("Not enough Meat", "You don't have enough Meat to buy that.", "Dang", null, null));
                    return false;
                }
                SoundPlayer.instance.PlayUISound(UISound.STOREBUYITEM);
                Store.current.RemoveItem(invid, 1);

                WolapPlugin.Archipelago.SendLocationCheck(item.data["source"]);

                traverse.Method("PostBuySell", [typeof(int), typeof(int), typeof(bool), typeof(bool)], [invid, iNpcStoreItem, isStoreItem, fReselect]).GetValue();

                return false;
            }
            else
            {
                
                bool sellWarning = ArchipelagoClient.SellWarningIds.Contains(item.id);
		        if (sellWarning)
		        {
                    Transform transform = npcStoreItem.transform;
		            iNpcStoreItem = transform.GetSiblingIndex();
		            fReselect = true;

                    if (npcStoreItem.isEquipped)
                    {
                        ConfirmState confirmState = new ConfirmState("Really sell this?", "You are wearing this item and this item is used for checks or progression later. Are you sure you want to sell it?", "Yes", "No", delegate(bool f)
			            {
				            if (f)
				            {
					            traverse.Method("SellItem", [typeof(NpcStoreItem)], [npcStoreItem]).GetValue();//this.SellItem(nsi);
					            traverse.Method("PostBuySell", [typeof(int), typeof(int), typeof(bool), typeof(bool)], [invid, iNpcStoreItem, isStoreItem, fReselect]).GetValue();//this.PostBuySell(invid, iNsi, fStore, fReselect);
				            }
			            });
			            WestOfLoathing.instance.state_machine.Push(confirmState);
			            return false;
                    }
                    else{
			            ConfirmState confirmState = new ConfirmState("Really sell this?", "This item is used for checks or progression later. Are you sure you want to sell it?", "Yes", "No", delegate(bool f)
			            {
				            if (f)
				            {
					            traverse.Method("SellItem", [typeof(NpcStoreItem)], [npcStoreItem]).GetValue();//this.SellItem(nsi);
					            traverse.Method("PostBuySell", [typeof(int), typeof(int), typeof(bool), typeof(bool)], [invid, iNpcStoreItem, isStoreItem, fReselect]).GetValue();//this.PostBuySell(invid, iNsi, fStore, fReselect);
				            }
			            });
			            WestOfLoathing.instance.state_machine.Push(confirmState);
			            return false;
                    }
		        }
		        return true;
            }
        }
    }
}
