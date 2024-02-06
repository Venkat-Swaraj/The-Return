using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Get")]
public class Get : Action
{
    public override void RespondToInput(GameController gameController, string noun)
    {
        foreach(Item item in gameController.player.currentLocation.items)
        {
            if(item.itemEnabled && item.itemName == noun)
            {
                if(item.playerCanTake)
                {
                    gameController.player.inventory.Add(item);
                    gameController.player.currentLocation.items.Remove(item);
                    gameController.currentText.text = "You take " + noun;
                    return;
                }
            }
        }
        gameController.currentText.text = "You can't take that";
    }
}
