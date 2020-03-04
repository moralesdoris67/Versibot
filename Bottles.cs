using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bottles : MonoBehaviour
{
  private int currentScore;
  public Text ScoreText;
  void Start ()
{
  currentScore=0;
}

void Update ()
{
}
private void HandleScore(){
  ScoreText.text="Score: "+currentScore;
}

void OnTriggerEnter(Collider other)
{

  Destroy(gameObject);
  currentScore=1;
  currentScore++;
}
}
