using UnityEngine;

public class Obsticule : MonoBehaviour
{
    public GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            Destroy(collision.gameObject);
            Instantiate(player, new Vector3(0,1,0),Quaternion.identity);
        }
    }
}
