using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Canvas canvas;
    PlayerMovement movement;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        movement = other.gameObject.GetComponent<PlayerMovement>();
        canvas.enabled = true;
        movement.enabled = false;
    }
}
