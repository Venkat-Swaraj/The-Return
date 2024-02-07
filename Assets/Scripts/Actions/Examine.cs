using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Examine")]
public class Examine : Action
{
    public override void RespondToInput(GameController gameController, string noun)
    {
        // Check in the inventory
        if(CheckItems(gameController,gameController.player.inventory,noun))
        {
            return;
        }
        // Check in the room
        if(CheckItems(gameController,gameController.player.currentLocation.items,noun))
        {
            return;
        }
        gameController.currentText.text = "You can't see a " + noun;
    }

    private bool CheckItems(GameController gameController, List<Item> items,string noun)
    {
        foreach (Item item in items)
        {
            if(item.itemName == noun)
            {
                if(item.InteractionWith(gameController,"examine"))
                {
                    return true;
                }
                gameController.currentText.text = "You see a " + item.description;
                return true;
            }
        }
        return false;
    }
}
