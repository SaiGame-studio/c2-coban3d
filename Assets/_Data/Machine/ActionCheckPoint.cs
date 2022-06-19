using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionCheckPoint : Action
{

    public MachineCtrl machine;

    void Start()
    {
        this.machine = transform.parent.GetComponent<MachineCtrl>();
    }

    public override void Act()
    {
        this.SaveCheckPoint();
    }

    protected virtual void SaveCheckPoint()
    {
        Debug.Log(transform.name + ": SaveCheckPoint");
        CheckPointManager.instance.SetCheckPoint(this.machine);
    }
}
