using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachinePlatformCtrl : MachineCtrl
{
    [Header("Platform")]
    public MoveByTrigger moveByTrigger;

    protected override void Start()
    {
        base.Start();
        this.moveByTrigger = GetComponent<MoveByTrigger>();
    }
}
