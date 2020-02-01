using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoresystem : MonoBehaviour
{
  public Text scoreText;
  private float timer;
  private float score;
  private int start = 18000;


    void Update()
    {

      int t=start-=1;

      string minutes=((start/60)/60).ToString("00");
      string seconds =(((int)start/60)/5).ToString("00");
      string miliseconds=(t%60).ToString("00");

      scoreText.text="Time: "+minutes+":"+seconds+":"+miliseconds;//+miliseconds;

}
}
