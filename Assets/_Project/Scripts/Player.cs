using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Player player;
    public GameObject SnakeTail;
    public int Text;
    public List<GameObject> Tails;
    public float BonesDistance;

    public GameObject BonesPrefabs;

    public Rigidbody body;
    public float speed;
    public Game Game;
    public void Tail()
    {
        GameObject SnakeTail = Instantiate(BonesPrefabs);
        Tails.Add(BonesPrefabs);
       
    }
    public void Die()
    {
        Game.OnPlayerDied();
        body.velocity = Vector3.zero;
    }

    public void ReachFinish()
    {
        Game.OnPlayerReachFinish();
        body.velocity = Vector3.zero;
    }

    public void SnakeSpeed()
    {
        body.velocity = new Vector3(0, 0, speed);
    }
}
