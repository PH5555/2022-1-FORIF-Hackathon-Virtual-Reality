using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl : MonoBehaviour
{
    private Transform camTr;
    private CharacterController cc;
    
    public float speed = 1.0f;

    void Awake()
    {
        camTr = Camera.main.GetComponent<Transform>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLookAt();
    }

    void MoveLookAt(){
        Vector3 dir = camTr.TransformDirection(Vector3.forward);
        cc.SimpleMove(dir * speed);
    }
}