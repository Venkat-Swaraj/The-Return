using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Interaction
{
    public Action action;

    [TextArea]
    public string response;

    public List<Item> itemsToEnable = new();
    public List<Item> itemsToDisable = new();

    public List<Connection> connectionsToEnable = new();
    public List<Connection> connectionsToDisable = new();
}
