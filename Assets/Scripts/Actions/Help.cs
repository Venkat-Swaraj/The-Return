using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Helper",menuName ="Actions/Help")]
public class Help : Action
{
    public override void RespondToInput(GameController gameController, string noun)
    {
        gameController.currentText.text = "Type a verb followed by noun ((eg:\"go north\"))\n";
        gameController.currentText.text += "Allowed verbs:\nExamine, Get, Give, Go, Help, Inventory, Say, TalkTo, Use";
    }
}
