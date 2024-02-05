using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Actions/Go")]
public class Go : Action
{
    public override void RespondToInput(GameController gameController, string noun)
    {
        if(gameController.player.ChangeLocation(gameController,noun))
        {
            gameController.DisplayLocation();
        }
        else
        {
            gameController.currentText.text = "You can't go that wayy!";
        }
    }
}
