using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Location currentLocation;

    public List<Item> inventory = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool ChangeLocation(GameController gameController, string connectionNoun)
    {
        Connection connection = currentLocation.GetConnection(connectionNoun);
        if (connection != null)
        {
            if(connection.connectionEnabled)
            {
                currentLocation = connection.location;
                return true;
            }
        }
        return false;
    }

    internal bool CanUseItem(GameController gameController, Item item)
    {
        if(item.targetItem == null) {
            return true;
        }
        if(HasItem(item.targetItem))
        {
            return true;
        }
        if(currentLocation.HasItem(item.targetItem))
        {
            return true;
        }

        return false;
    }

    private bool HasItem(Item item)
    {
        foreach(Item item2 in inventory)
        {
            if(item2 == item & item2.itemEnabled)
            {
                return true;
            }
        }
        return false;
    }
}
