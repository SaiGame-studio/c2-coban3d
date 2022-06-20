using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionCheckPoint : Action
{

    public MachineCtrl machine;
    public CheckPointLight checkPointLight;

    void Start()
    {
        this.machine = transform.parent.GetComponent<MachineCtrl>();
        this.checkPointLight = GetComponentInChildren<CheckPointLight>();
    }

    public override void Act()
    {
        this.SaveCheckPoint();
        this.checkPointLight.On();
    }

    protected virtual void SaveCheckPoint()
    {
        CheckPointManager.instance.SetCheckPoint(this.machine);
    }
}
