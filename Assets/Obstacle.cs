using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    
    //Name
    public string name;
    //Defines if the object is on the ground(0), in the air(1) or both(2)
    public int type;
    //Indicates if the obstacle is an attacking opponent(true) or not(false)
    public bool attacks;
    //Variable indicating damages done to Godzilla
    public int attackDamage;
    //Variable indicating damages done to Godzilla when colliding with the obstacle
    public int collisionDamage;
    //For obstacles health
    public int healthPoints;
    //Just in case
    public int armorPoints;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Init(string nam, MeshFilter mesh, int typ, bool atk, int atkdmg, int coldmg, int hp, int armpts)
    {
        name = nam;
        type = typ;
        attacks = atk;
        attackDamage = atkdmg;
        collisionDamage = coldmg;
        healthPoints = hp;
        armorPoints = armpts;

        GetComponent<MeshFilter>().sharedMesh = mesh.sharedMesh;
    }
}
