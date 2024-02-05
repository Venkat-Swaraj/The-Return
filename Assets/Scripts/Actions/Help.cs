using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Helper",menuName ="Actions/Help")]
public class Help : Action
{
    public override void RespondToInput(GameController gameController, string verb)
    {
        gameController.currentText.text = "Type a very followed by noun ((eg:\"go north\"))\n";
        gameController.currentText.text += "Allowed verbs:\nExamine, Get, Give, Go, Help, Inventory, Say, TalkTo, Use";
    }
}
