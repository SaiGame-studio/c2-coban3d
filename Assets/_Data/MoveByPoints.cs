using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByPoints : MonoBehaviour
{
    public Transform pointsHolder;
    public int pointInput = 0;
    public List<Transform> points;

    void Start()
    {
        this.LoadPoints();
    }

    private void FixedUpdate()
    {
        
    }

    protected virtual void LoadPoints()
    {
        string name = transform.name + "_Points";
        this.pointsHolder = GameObject.Find(name).transform;
        foreach (Transform point in this.pointsHolder)
        {
            this.points.Add(point);
        }
    }
}
