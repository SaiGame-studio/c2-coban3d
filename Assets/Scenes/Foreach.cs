using UnityEngine;

public class Foreach : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        foreach (Transform monster in transform)
        {
            //Debug.Log(monster.name);
            if (this.IsDead(monster))
            {
                Debug.Log(monster.name);
            }
        }
    }

    protected virtual bool IsDead(Transform monster)
    {
        if (monster.name.Contains("Dead")) return true;
        return false;
    }
}
