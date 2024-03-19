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
            // Create a Quaternion that rotates on the Z by 90.0f
            Quaternion quaternion = Quaternion.Euler(0f, 0f, 90.0f);
            Instantiate(prefab, holsterTransform.position, quaternion);
        }
    }
}
