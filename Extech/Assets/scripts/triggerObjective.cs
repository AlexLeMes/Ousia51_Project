﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerObjective : MonoBehaviour {

    GameObject player;
    objectives _objectvies;

    public string objectivesText;
    public string objectiveCompleteText;

    public bool objectiveComplete = false;

    public int objectiveID = 0;
    public int completedID = 1;

    public float objectiveTime = 0f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        _objectvies = player.GetComponent<objectives>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            toggleObjective();
        }
    }

    public void toggleObjective()
    {
        _objectvies.updateObjective(objectivesText, objectiveID);
    }

    public void completeObjective(int id)
    {
        if(id == objectiveID)
        {
            _objectvies.updateObjective(objectiveCompleteText, objectiveID);
        }
    }

    public void bombObjective()
    {
        //logic here for toggling the bomb
        _objectvies.toggleBombObjective(objectiveTime);
    }

}
