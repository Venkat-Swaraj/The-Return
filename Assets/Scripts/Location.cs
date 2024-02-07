using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public string locationName;

    [TextArea]
    public string description;

    public Connection[] connections;

    public List<Item> items = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetConnectionsText()
    {
        string connectionDescription = "";
        foreach (var connection in connections)
        {
            if(connection.connectionEnabled)
            {
                connectionDescription += connection.description+"\n";
            }
            
        }
        return connectionDescription;
    }

    public string GetItemsText()
    {
        if (items.Count == 0)
            return "";
        else
        {
            string itemDescription = "You see ";
            bool first = true;
            foreach (var item in items)
            {
                if(item.itemEnabled)
                {
                    if (!first)
                    {
                        itemDescription += " and ";
                    }
                    itemDescription += item.description;
                    first = false;
                }
            }
            itemDescription += "\n";
            return itemDescription;
        }
    }

    public Connection GetConnection(string connectionNoun)
    {
        foreach (var connection in connections)
        {
            
            if(connection.connectionName.ToLower() == connectionNoun.ToLower())
            {
                return connection;
            }
            
        }
        return null;
    }

    internal bool HasItem(Item item)
    {
        foreach(Item item1 in items)
        {
            if(item == item1 && item1.itemEnabled)
                return true;
        }
        return false;
    }
}
