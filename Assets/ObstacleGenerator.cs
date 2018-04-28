using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{

    [System.Serializable]
    public class ObstacleStats : System.Object
    {
        //Name
        public string name;
        //Mesh
        public MeshFilter mesh;
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
    }

    public ObstacleStats[] obstacles;

    public GameObject Roads;

    public Vector3 minPos;
    public Vector3 maxPos;

    public float Timer;
    public float TimerMin;
    public float TimerMax;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Timer = Random.Range(TimerMin, TimerMax);
            PlaceObstacle(0);
        }
    }

    private void PlaceObstacle(int id)
    {
        int indexRoad = Random.Range(0, Roads.transform.childCount);
        ObstacleStats obs = obstacles[id];
        GameObject obj = new GameObject();
        //obj = obs.mesh;
        obj.AddComponent<MeshFilter>();
        obj.AddComponent<MeshRenderer>();
        obj.AddComponent<Obstacle>();
        obj.GetComponent<Obstacle>().Init(obs.name, obs.mesh, obs.type, obs.attacks, obs.attackDamage, obs.collisionDamage, obs.healthPoints, obs.armorPoints);
        obj.name = obs.name;
        obj.transform.position = Roads.transform.GetChild(indexRoad).transform.position;
    }
}
