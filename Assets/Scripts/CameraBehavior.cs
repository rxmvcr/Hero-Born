using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Vector3 camOffset = new Vector3(0f, 3.2f, -4.6f);

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        this.transform.position = target.TransformPoint(camOffset);

        this.transform.LookAt(target);
    }
}
