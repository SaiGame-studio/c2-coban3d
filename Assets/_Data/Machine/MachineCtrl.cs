using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineCtrl : MonoBehaviour
{
    [Header("Machine")]
    public Trigger trigger;
    public Action action;

    protected virtual void Start()
    {
        this.trigger = transform.Find("Trigger").GetComponent<Trigger>();
        this.action = transform.Find("Action").GetComponent<Action>();
    }
}
