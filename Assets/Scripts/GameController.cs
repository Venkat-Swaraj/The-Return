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

    public Action[] actions;
    void Start()
    {
        logText.text = introText;
        DisplayLocation();
        textEntryField.ActivateInputField();
    }


    void Update()
    {
        
    }

    public void DisplayLocation()
    {
        string description = player.currentLocation.description + "\n";
        description += player.currentLocation.GetConnectionsText();
        description += player.currentLocation.GetItemsText();
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
        foreach(Action action in actions)
        {
            if(action.keyword.ToLower() == separateWords[0])
            {
                if(separateWords.Length>1)
                {
                    action.RespondToInput(this, separateWords[1]);
                }
                else
                {
                    action.RespondToInput(this, "");
                }
                return;
            }
        }

        currentText.text = "Nothing happens (Having Trouble? Type Help)";
    }
}
