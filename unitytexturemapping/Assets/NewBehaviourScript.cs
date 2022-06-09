using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float h = 0.0f;
    float v = 0.0f;
    float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(h, 0, v);

        if (Input.GetKeyDown(KeyCode.Keypad1))
            speed = 1.0f;
        else if (Input.GetKeyDown(KeyCode.Keypad2))
            speed = 0.3f;

        transform.Translate(vec * Time.deltaTime * speed);

        if (h != 0 || v != 0)
        {
            //Vector3 vec = new Vector3(h, 0, v);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(vec), Time.deltaTime * speed);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody>().AddForce(Vector3.up * 500);

    }
}
