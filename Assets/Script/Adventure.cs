using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Adventure : MonoBehaviour {

	private string adventureName;
	int nbCampain;
	private List<Campain> questList = new List<Campain>();
	public GameObject addCampain;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void AddCampain () {
		GameObject campain = (GameObject)Instantiate(Campain)
	}
}
