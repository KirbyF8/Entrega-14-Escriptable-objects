using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Template of what represents an exit

[Serializable] // Attribute that allows us to modify the properties of the class in the inspector
public class Exit
{
    public string direction; // Direction where the exit is located
    [TextArea(5,15)] public string description; // Description of the exit
    public RoomSO room; // Room to which we access through this exit 
}
