using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    GameObject[] player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        scoreText.text = player[0].transform.position.z.ToString("0");
    }
}
