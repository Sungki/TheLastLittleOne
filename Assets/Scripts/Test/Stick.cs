﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour {
    public GameObject target_go;
    private FixedJoint2D fixed_joint;
    public HingeJoint2D hj;

    private void Start()
    {
        fixed_joint = GetComponent<FixedJoint2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
//        Torque1.flag = true;
  //      Torque.flag = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Torque1.flag = true;
        Torque.flag = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
//            this.transform.parent = null;
//            lockJoint();
        }
    }

    private void lockJoint()
    {
        fixed_joint = target_go.AddComponent<FixedJoint2D>() as FixedJoint2D;
        fixed_joint.connectedBody = target_go.GetComponent<Rigidbody2D>();

//        hj = this.gameObject.AddComponent<HingeJoint2D>() as HingeJoint2D;
  //      hj.connectedBody = target_go.GetComponent<Rigidbody2D>();
    }
}
