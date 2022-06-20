using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Rigidbody _rigidbody;

    private void Start()
    {
        this._rigidbody = GetComponent<Rigidbody>();
    }
}
