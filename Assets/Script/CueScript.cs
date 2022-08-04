using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueScript : MonoBehaviour
{
    public GameObject Target;
    public float Strength = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X"), Space.Self);
        transform.GetChild(1).Rotate(Vector3.right, Input.GetAxis("Mouse Y"), Space.Self);

        
        if(Input.GetMouseButtonDown(0)) {
            Rigidbody rb = Target.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * Strength, ForceMode.Impulse);
        }
    }

    void LateUpdate() {
        transform.position = Target.transform.position;
    }
}
