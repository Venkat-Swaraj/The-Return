using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Use")]
public class Use : Action
{
    public override void RespondToInput(GameController gameController, string noun)
    {
        // Use in the inventory
        if (UseItems(gameController, gameController.player.inventory, noun))
        {
            return;
        }
        // Use in the room
        if (UseItems(gameController, gameController.player.currentLocation.items, noun))
        {
            return;
        }
        gameController.currentText.text = "There is no " + noun;
    }

    private bool UseItems(GameController gameController, List<Item> items, string noun)
    {
        foreach (Item item in items)
        {
            if (item.itemName == noun)
            {
                if (gameController.player.CanUseItem(gameController, item))
                {
                    if (item.InteractionWith(gameController, "examine"))
                    {
                        return true;
                    }
                    
                }
                gameController.currentText.text = "The " + noun + " does nothing";
                return true;
            }
        }
            
        
        return false;
    }
}
