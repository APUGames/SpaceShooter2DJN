using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponContoller : MonoBehaviour
{
    public GameObject prefab;
    public Transform holsterTransform;
    public float holsterPaddingY;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Instantiate a prefab in 2d space at the transform of the parent
            Vector3 newPosition = new Vector3(holsterTransform.position.x, holsterTransform.position.y + holsterPaddingY, transform.position.z);
            Instantiate(prefab, newPosition, transform.rotation, transform);
        }
    }
}
