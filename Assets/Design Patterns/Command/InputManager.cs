using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private void RunPlayerCommand(PlayerMover playerMover, Vector3 movement)

    {
        if (playerMover == null)
        {
            return;
        }
        if (playerMover.IsValidMove(movement))
        {
            ICommand command = new MoveCommand(playerMover, movement);
            CommandInvoker.ExecuteCommand(command);
        }
    }
}
