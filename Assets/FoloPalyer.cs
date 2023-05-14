using UnityEngine;

public class FoloPalyer : MonoBehaviour
{
    GameObject [] player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        transform.position = player[0].transform.position + offset;

    }
}
