using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int winningScore;
    public int startingScore;
    public GameObject targetPrefab;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        this.score = this.startingScore;
        InvokeRepeating("Spawn", 1, 1);
    }
    public void IncrementScore()
    {
        this.score++;
        print(this.score);
        if (this.score == this.winningScore)
        {
            print("You Won!");
            CancelInvoke("Spawn");
        }
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    void Spawn() {
        float x = Random.Range(-7.0f, 7.0f);
        float y = Random.Range(-4.0f, 4.0f);
        Instantiate(this.targetPrefab, new Vector3(x, y), Quaternion.identity);
    }
    public void DecrementScore()
    {
        this.score --;
        print(this.score);
        if (this.score == 0)
        {
            print("Game Over");
            CancelInvoke("Spawn");
        }


    } 
}
