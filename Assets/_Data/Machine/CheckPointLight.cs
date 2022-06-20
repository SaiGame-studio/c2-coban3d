using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointLight : MonoBehaviour
{
    public Transform model;
    public Renderer _renderer;
    public Material materialOff;
    public Material materialOn;
    public bool on = false;

    private void Start()
    {
        this.model = transform.Find("Model");
        this._renderer = this.model.GetComponent<Renderer>();
        this.Off();
    }

    public virtual void On()
    {
        this.on = true;
        this._renderer.material = this.materialOn;
    }

    public virtual void Off()
    {
        this.on = false;
        this._renderer.material = this.materialOff;
    }
}
