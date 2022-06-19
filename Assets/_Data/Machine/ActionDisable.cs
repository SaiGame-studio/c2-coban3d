using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionDisable : Action
{
    public float disableDelay = 0.3f;
    public float respawnDelay = 5f;

    public override void Act()
    {
        Invoke("Disable", this.disableDelay);
        Invoke("Respawn", this.respawnDelay);
    }

    protected virtual void Disable()
    {
        transform.parent.gameObject.SetActive(false);
    }

    protected virtual void Respawn()
    {
        transform.parent.gameObject.SetActive(true);
    }
}
