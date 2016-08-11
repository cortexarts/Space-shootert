﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject hazard;
	public Vector3 spawnValues ;
	public int hazardCount ;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	public GUIText scoreText;
	public GUIText restartText;
	public GUIText gameOverText;

	private bool gameOver;
	private bool restart;
	private int scoreValue;

	void Start ()
	{
		gameOver = false;
		restart = false;
		gameOverText.text = "";
		restartText.text = "";
		scoreValue = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}

	void Update()
	{
	if (restart) 
	{
	if (Input.GetKeyDown (KeyCode.R))
	{
				Application.LoadLevel (Application.loadedLevel);
	}
	}
	}
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i =0; i < hazardCount; i++) 
			{

				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;  
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		
			if (gameOver)
			{
				restartText.text = "Press 'R' for restart";
				restart = true;
				break;
			}
		}
	}
	public void AddScore(int newScoreValue)
	{
		scoreValue += newScoreValue;
		UpdateScore ();
	}
	void UpdateScore()
	{
		scoreText.text = "Score: " + scoreValue;
	}
	public void GameOver()
	{
  	gameOverText.text = "Game Over!";
	gameOver = true;
	}
	}
