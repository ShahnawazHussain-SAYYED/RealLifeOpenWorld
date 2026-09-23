using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6f;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 d = new Vector3(h, 0, v);
        if (d.sqrMagnitude > .01f)
        {
            transform.position += d.normalized * moveSpeed * Time.deltaTime;
            transform.rotation = Quaternion.LookRotation(d);
        }
    }
}