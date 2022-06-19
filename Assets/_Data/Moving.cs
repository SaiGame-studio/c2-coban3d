using UnityEngine;

public class Moving : MonoBehaviour
{
    public PlayerCtrl playerCtrl;
    public float jumpHeight = 0f;
    public float jumpSpeed = 0.15f;
    public float jumpMax = 0.2f;
    public float thrust = 7f;

    private void Start()
    {
        this.playerCtrl = transform.parent.GetComponent<PlayerCtrl>();
    }

    protected void Update()
    {
        this.Jumping();
    }

    private void FixedUpdate()
    {
        this.MoveByRigibody();
    }

    protected virtual void MoveByRigibody()
    {
        float x = InputManager.instance.vertical;
        float z = -1 * InputManager.instance.horizontal;
        Vector3 direction = new Vector3(x, this.jumpHeight, z);
        this.playerCtrl._rigidbody.AddForce(direction * this.thrust);
    }

    protected virtual void Jumping()
    {
        if (InputManager.instance.jump == 0) return;
        this.jumpHeight += this.jumpSpeed;
        Invoke("ResetJump", this.jumpMax);
    }

    protected virtual void ResetJump()
    {
        this.jumpHeight = 0f;
    }
}
