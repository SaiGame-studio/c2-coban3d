using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListChild : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Many code here
        this.ShowAllChildren();
    }

    protected virtual void ShowAllChildren()
    {
        foreach (Transform child in transform)
        {
            Debug.Log(child.name);
        }
    }

}
