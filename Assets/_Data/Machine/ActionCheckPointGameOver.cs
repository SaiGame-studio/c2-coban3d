using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionCheckPointGameOver: ActionCheckPoint
{
    public override void Act()
    {
        base.Act();
        GameManager.instance.GameOver();
    }
}
