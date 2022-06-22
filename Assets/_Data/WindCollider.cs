using UnityEngine;

public class WindCollider : MonoBehaviour
{
    [SerializeField] protected Rigidbody _rigidbody;
    [SerializeField] protected float thrust = 5f;
    [SerializeField] protected Vector3 direction = new Vector3(-1,0,0);

    protected virtual void OnTriggerEnter(Collider other)
    {
        this._rigidbody = other.GetComponent<Rigidbody>();
    }

    protected virtual void OnTriggerExit(Collider other)
    {
        this._rigidbody = null;
    }

    private void FixedUpdate()
    {
        this.MoveByRigibody();
    }

    protected virtual void MoveByRigibody()
    {
        if (this._rigidbody == null) return;
        this._rigidbody.AddForce(this.direction * this.thrust);
    }
}
