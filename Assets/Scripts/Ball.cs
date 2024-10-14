using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Ball : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int point = 0;
    public GameObject player;
    public GameObject ball;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ball")
        {
            scoreText.text = (++point).ToString();
            player.transform.position = new Vector3(-5.69f,0,0);
            ball.transform.position = new Vector3(0,0,0);
        }
    }
}
