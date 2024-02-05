using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public string locationName;

    [TextArea]
    public string description;

    public Connection[] connections;
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
}
