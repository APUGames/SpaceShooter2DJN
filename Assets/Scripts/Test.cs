using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed;

    private void Awake()
    {
        Debug.Log("I'm awok");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am a player");
        Debug.Log(speed);
        // transform.position = new Vector3(transform.position.x + 300.0f, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("yo");
        // gameObject.transform.Rotate(new Vector3(5.0f, 5.0f));
        // float speed = 10.0f;
        float horizontalDirection = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");
        // Debug.Log(direction);
        transform.Translate(speed * Time.deltaTime * new Vector2(horizontalDirection, verticalDirection));
        // transform.position = new Vector3(transform.position.x + 1.0f, transform.position.y, transform.position.z);

    }
}
