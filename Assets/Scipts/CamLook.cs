using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLook : MonoBehaviour
{
    Camera cam;
    public static GameObject look = null;

    // Start is called before the first frame update
    void Start()
    {
        this.cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && look != null)
        {
            look.GetComponent<Pickup>().PutDown();
            look = null;
        }

        if (look == null) return;

        look.transform.position = this.cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.5f));
        look.transform.rotation = this.transform.rotation * Quaternion.Euler(0, 90, 0);
        //look.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
    }
}
