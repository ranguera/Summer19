using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bump : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            GetComponent<Rigidbody>().AddForce(Vector3.up*1000f);

        if(Input.GetKey(KeyCode.W))
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 1000f);
        if (Input.GetKey(KeyCode.S))
            GetComponent<Rigidbody>().AddForce(Vector3.back * 1000f);
        if (Input.GetKey(KeyCode.A))
            GetComponent<Rigidbody>().AddForce(Vector3.left * 1000f);
        if (Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody>().AddForce(Vector3.right * 1000f);
    }
}
