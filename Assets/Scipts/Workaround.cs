using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workaround : MonoBehaviour
{
    public Transform t;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(t.position.x, this.transform.position.y, t.position.z);
    }
}
