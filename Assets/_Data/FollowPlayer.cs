using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offet = new Vector3(-5, 5, 0);

    void Start()
    {
        this.player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        transform.position = this.player.transform.position + this.offet;
    }

    private void FixedUpdate()
    {
        this.LookAtPlayer();
        //this.LookByMouse();
    }

    protected virtual void LookAtPlayer()
    {
        transform.LookAt(this.player.position);
    }
}
