using UnityEngine;
public class VehicleController : MonoBehaviour
{
    public float speed = 12f;
    public bool playerInside;
    void Update()
    {
        if (!playerInside) return;
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * 80f * Time.deltaTime);
    }
    public void EnterVehicle() { playerInside = true; }
    public void ExitVehicle() { playerInside = false; }
}