using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Robot, ISwitchable
{
    private bool isActive;
    public bool IsActive => isActive;
    public void Activate()
    {
        isActive = true;
        Debug.Log("The door is open.");
    }
    public void Deactivate()
    {
        isActive = false;
        Debug.Log("The door is closed.");
    }

    public override void FindPath()
    {
        throw new System.NotImplementedException();
    }
}
