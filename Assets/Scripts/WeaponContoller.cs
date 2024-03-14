using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponContoller : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Instantiate a prefab in 2d space at the transform of the parent
            Vector3 newPosition = new Vector3(400f, transform.position.y + 300.0f, transform.position.z);
            Instantiate(prefab, newPosition, transform.rotation, transform);
            // clone.transform.position = transform.position;
            // Debug.Log(clone.transform.position);
        }
    }
}
