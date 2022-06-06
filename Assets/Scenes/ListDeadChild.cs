using UnityEngine;

public class ListDeadChild : ListChild
{
    protected override void ShowAllChildren()
    {
        foreach (Transform child in transform)
        {
            if (this.IsDead(child))
            {
                Debug.Log(child.name);
            }
        }
    }

    protected virtual bool IsDead(Transform monster)
    {
        if (monster.name.Contains("Dead")) return true;
        return false;
    }
}
