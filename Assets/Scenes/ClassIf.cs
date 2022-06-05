using UnityEngine;

public class ClassIf : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        if (transform.position.x > 10)
        {
            Debug.Log(transform.name + ": Move to X > 10");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x > 10)
        {
            Debug.Log(transform.name + ": Move to X > 10");
        }
        else
        {
            Debug.Log(transform.name + ": Small then 10");
        }
    }
}
