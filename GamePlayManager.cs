using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GamePlayManager : MonoBehaviour
{
    public static GamePlayManager instance;
    [SerializeField]GameObject targetPrefab;

    [SerializeField] GameObject winPannel;
    int score = 0;
    bool hasWon = false;
    [SerializeField] Text scoretext;
    private void Awake()
    {
        if (!instance) instance = this; 
    }
    private void Start()

    {
        winPannel.SetActive(false);
        //InvokeRepeating("SpawnTarget",1f,1f);
    }
    public void StartSpawningTarget()
    {
        InvokeRepeating("SpawnTarget", 1f, 1f);
    }
    private void Update()
    {
        if(hasWon)CancelInvoke("SpawnTarget");

    }
    void SpawnTarget()
    {
        float xPos = Random.Range(-7.4f,7.4f);
        float yPos = Random.Range(-3.5f,3.5f);

        Vector3 randomtargetPos = new Vector3(xPos, yPos, 0);
        Instantiate(targetPrefab,randomtargetPos, Quaternion.identity);
    }
    public void IncrementScore()
    {
        score++;
        scoretext.text = score.ToString();
        if(score >= 10)
        {
            winPannel.SetActive(true);
            hasWon = true;
        }
        Debug.Log("Score : " + score);
    }
}
