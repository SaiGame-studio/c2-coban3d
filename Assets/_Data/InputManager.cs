using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;//Singleton

    public float reload = 0;
    public float jump = 0;
    public float vertical = 0;
    public float horizontal = 0;

    private void Awake()
    {
        InputManager.instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetInputMovement();
    }

    protected virtual void GetInputMovement()
    {
        this.reload = Input.GetAxis("Reload");
        this.vertical = Input.GetAxis("Vertical");
        this.horizontal = Input.GetAxis("Horizontal");
        this.jump = Input.GetAxis("Jump");
    }

    public virtual float IsReload()
    {
        return this.reload;
    }
}
