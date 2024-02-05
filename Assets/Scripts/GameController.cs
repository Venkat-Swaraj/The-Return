using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public Player player;
    public TMP_InputField textEntryField;
    public TextMeshProUGUI logText;
    public TextMeshProUGUI currentText;

    [TextArea]
    public string introText;
    // Start is called before the first frame update
    void Start()
    {
        logText.text = introText;
        DisplayLocation();
        textEntryField.ActivateInputField();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayLocation()
    {
        string description = player.currentLocation.description + "\n";
        description += player.currentLocation.GetConnectionsText() + "";

        currentText.text = description;
    }

    public void TextEntered()
    {
        LogCurrentText();
        ProcessInput(textEntryField.text);
        textEntryField.text = "";
        textEntryField.ActivateInputField() ;
    }

    void LogCurrentText()
    {
        logText.text += currentText.text;
        logText.text += "\n\n";

        logText.text += "<color=#aaccaaff>"+textEntryField.text+"</color>";
        logText.text += "\n\n";


    }

    void ProcessInput(string input)
    {
        input = input.ToLower();
        char[] delimitter = { ' ' };
        string[] separateWords = input.Split(delimitter);

        /*TODO:
         Process Input into commands
         */

        currentText.text = "Nothing happens (Having Trouble? Type Help)";
    }
}
