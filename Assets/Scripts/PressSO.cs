using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Object/Input Actions/Press")]
public class PressSO : InputActionSO
{
    public override void RespondToInput(string[] separatedInput)
    {
        RoomManager.Instance.TryToPress(); // It is assumed that separatedInput[1] = itemName
        
    }

}
