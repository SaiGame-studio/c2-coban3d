using UnityEngine;

public class MoveByTrigger : MoveByPoints
{
    [Header("Trigger")]
    [SerializeField] protected bool on = false;

    private void Reset()
    {
        this.speed = 3;
    }

    protected override void PointMoving()
    {
        if (!this.on) return;
        base.PointMoving();
    }

    protected override void NextPointCalculate()
    {
        base.NextPointCalculate();
        if (this.pointDistance == 0 && this.pointIndex == 1) this.Off();
    }

    public virtual void On()
    {
        this.on = true;
    }

    public virtual void Off()
    {
        this.on = false;
    }
}


