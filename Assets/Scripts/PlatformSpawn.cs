using UnityEngine;
using System.Collections;

public class PlatformSpawn : MonoBehaviour {
    public GameObject platformSpawn;
    public GameObject floor2;
	public GameObject floor3;
	public GameObject floor4;
	public GameObject floor5;
	public GameObject floor6;
	public GameObject floor7;
    public float SpawnRate;
    private float NextPlatform;

	// Use this for initialization
	void Start () {
        NextPlatform = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > NextPlatform)
        {
			float platformNumber = Mathf.Floor(Random.Range(2.0f,7.0f));
			GameObject temp;
			NextPlatform = Time.time + SpawnRate;
			
			//if for each floor
			if(platformNumber == 2){
			temp = Instantiate(floor2, platformSpawn.transform.position, platformSpawn.transform.rotation) as GameObject;
			Destroy(temp, 10);
			}else if(platformNumber == 3){
				temp = Instantiate(floor3, platformSpawn.transform.position, platformSpawn.transform.rotation) as GameObject;
				Destroy(temp, 10);
			}
			else if(platformNumber == 4){
				temp = Instantiate(floor4, platformSpawn.transform.position, platformSpawn.transform.rotation) as GameObject;
				Destroy(temp, 10);
			}
			else if(platformNumber == 5){
				temp = Instantiate(floor5, platformSpawn.transform.position, platformSpawn.transform.rotation) as GameObject;
				Destroy(temp, 10);
			}else if(platformNumber == 6){
				temp = Instantiate(floor6, platformSpawn.transform.position, platformSpawn.transform.rotation) as GameObject;
				Destroy(temp, 10);
			}else if(platformNumber == 7){
				temp = Instantiate(floor7, platformSpawn.transform.position, platformSpawn.transform.rotation) as GameObject;
				Destroy(temp, 10);
			}
		   
        }
	}
}
