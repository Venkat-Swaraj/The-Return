using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Actions/Inventory")]
public class Inventory : Action
{
    public override void RespondToInput(GameController gameController, string noun)
    {
        if(gameController.player.inventory.Count == 0)
        {
            gameController.currentText.text = "You have nothing";
            return;
        }
        else
        {
            string inventoryItems = "You have ";
            bool first = true;
            foreach(Item item in gameController.player.inventory)
            {
                if (first)
                {
                    inventoryItems += " a " + item.itemName;
                }
                else
                {
                    inventoryItems += " and a "+item.itemName;
                }
                
                first = false;
            }
            gameController.currentText.text = inventoryItems;
            return;
        }
    }
}
