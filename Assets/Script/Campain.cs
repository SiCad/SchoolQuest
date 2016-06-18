using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Campain : MonoBehaviour {

	public int nbQuest, H, L, Weight;
	private string campainName;
	private List<Quest> questList = new List<Quest>();
	public GameObject addQuest;

	// Use this for initialization
	void Start () {
		H = 400 / nbQuest;
		L = 60;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void AddQuest () {
		
	}
}