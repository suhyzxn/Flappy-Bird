using UnityEngine;

public class MovingBG : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position -= new Vector3(3f, 0, 0) * Time.deltaTime;
        if (transform.position.x <= -18.94f)
        {
            transform.position = new Vector3(19.09f, 0, 0);
        }
    }
}
