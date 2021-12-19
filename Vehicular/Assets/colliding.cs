using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliding : MonoBehaviour
{
    public GameObject current;
    private GameObject target;
    public GameObject cam;
    bool selectable = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m") && selectable)
        {
            Debug.Log("'m' pressed");
            
            Debug.Log("Name of target - " + target);
            target.GetComponent<carcontroller>().enabled = true;
            current.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            current.GetComponent<carcontroller>().enabled = false;
            cam.GetComponent<MoveCamera>()._target = target.transform;
            current = target;
            target = null;
            selectable = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Car")
		{
            Debug.Log("Car Detected. Press 'm'");
            target = other.gameObject;
            selectable = true;
        }
       
    }

}
