using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public virtual void Act()
    {
        Destroy(transform.parent.gameObject);
    }
}
