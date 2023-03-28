using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchCamery : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vTmp= new Vector3(target.position.x,target.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, vTmp, Time.deltaTime*5.0f);
    }
}