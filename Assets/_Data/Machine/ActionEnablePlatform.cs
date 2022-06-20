using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionEnablePlatform : Action
{
    public MachinePlatformCtrl machine;

    private void Start()
    {
        this.machine = transform.parent.GetComponent<MachinePlatformCtrl>();
    }

    public override void Act()
    {
        this.machine.moveByTrigger.On();
    }
}
