using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Vector3 position;
    private Quaternion rotation;
    private Vector3 localScale;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        rotation = this.transform.rotation;
        localScale = this.transform.localScale;
    }

    // Update is called once per frame
    public void PutDown()
    {
        this.transform.position = position;
        this.transform.rotation = rotation;
        this.transform.localScale = localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Vector3.Distance(player.position, this.transform.position) <= 5 && CamLook.look == null)
            CamLook.look = this.gameObject;
    }
}
