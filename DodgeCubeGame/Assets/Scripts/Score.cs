using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text scoreText;
    float offset = 0;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z + offset).ToString("0");
    }

}
