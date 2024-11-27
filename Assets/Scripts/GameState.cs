using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    enum state {
        playing,
        finished,
    };

public class GameState : MonoBehaviour
{
    public GameObject backgroundPrefab;
    state curState = state.playing;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       if (curState == state.finished)
       {
        Instantiate(backgroundPrefab);
       } 
        
    }

    public void endGame()
    {
        curState = state.finished;
        Debug.Log("game ended");
    }
}
