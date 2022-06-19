using UnityEngine;

public class Trigger : MonoBehaviour
{
    public MachineCtrl machine;

    void Start()
    {
        this.machine = transform.parent.GetComponent<MachineCtrl>();
    }

    private void OnTriggerEnter(Collider other)
    {
        this.machine.action.Act();
    }
}
