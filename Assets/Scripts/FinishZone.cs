using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishZone : MonoBehaviour
{
    private GameState state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void OnCollisionEnter(Collision collision) {
    Debug.Log("hit!");
    state.endGame();
}
}
