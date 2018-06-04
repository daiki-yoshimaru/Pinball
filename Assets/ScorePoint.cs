using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScorePoint : MonoBehaviour {
    private GameObject Points;
    int score = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag") { score += 10; }
        else if (collision.gameObject.tag == "LargeStarTag") { score += 20; }
        else if (collision.gameObject.tag == "SmallCloudTag") { score += 40; }
        else if (collision.gameObject.tag == "LargeCloudTag") { score += 50; }

        Points.GetComponent<Text>().text = score.ToString();
    }

    // Use this for initialization
    void Start () {
        this.Points = GameObject.Find("Points");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
