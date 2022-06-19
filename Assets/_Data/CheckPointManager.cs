using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public static CheckPointManager instance;//Singleton

    public PlayerCtrl player;
    public MachineCtrl currentCheckPoint;

    private void Awake()
    {
        CheckPointManager.instance = this;
    }

    private void Start()
    {
        this.player = GameObject.Find("Player").GetComponent<PlayerCtrl>();
    }

    private void Update()
    {
        this.CheckReload();
    }

    public virtual void SetCheckPoint(MachineCtrl newCheckPoint)
    {
        if (this.IsOldCheckPoint(newCheckPoint)) return;

        this.currentCheckPoint = newCheckPoint;
    }

    protected virtual bool IsOldCheckPoint(MachineCtrl newCheckPoint)
    {
        if(this.currentCheckPoint == null) return false;

        Regex re = new Regex(@"\d+");
        Match mCheckPoint;

        string newCheckPointName = newCheckPoint.name;
        mCheckPoint = re.Match(newCheckPointName);
        int newCheckPointNumber = Int32.Parse(mCheckPoint.Value);

        string oldCheckPointName = this.currentCheckPoint.name;
        mCheckPoint = re.Match(oldCheckPointName);
        int oldCheckPointNumber = Int32.Parse(mCheckPoint.Value);

        if (oldCheckPointNumber >= newCheckPointNumber) return true;

        return false;
    }

    protected virtual void CheckReload()
    {
        if (InputManager.instance.IsReload() == 0) return;
        if (this.currentCheckPoint == null) return;

        Vector3 checkPos = this.currentCheckPoint.transform.position;
        checkPos.y += 0.5f;

        this.player._rigidbody.velocity = Vector3.zero;
        this.player._rigidbody.angularVelocity = Vector3.zero;

        this.player.transform.position = checkPos;
    }
}
