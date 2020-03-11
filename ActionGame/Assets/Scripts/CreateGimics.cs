using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateGimics : MonoBehaviour
{
	public GameObject trap;
	public GameObject enemy;
    // Start is called before the first frame update

    void Start()
    {
        for(int i=0; i<20; i++)
        {
        	Vector3 postrap = new Vector3(Random.Range(0,10)-5, 1, Random.Range(2,60));
        	Vector3 posenemy = new Vector3(Random.Range(0,10)-5, 1, Random.Range(2,60));
        	Instantiate(trap, postrap, Quaternion.identity);
        	Instantiate(enemy, posenemy, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
