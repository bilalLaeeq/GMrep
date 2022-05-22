using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoretext;
    public int score= 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateScore",1,1);
    }

    void UpdateScore(){
        score ++;
    }
    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Score : "+ score.ToString();
    }
}
