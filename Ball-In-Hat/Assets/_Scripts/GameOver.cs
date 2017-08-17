using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public LevelManager l;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        l.GameOver();
    }
}
