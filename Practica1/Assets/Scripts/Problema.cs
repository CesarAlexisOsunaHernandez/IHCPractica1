using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = {8,1,2,2,3};
		int z;
		//Debug.Log("[");
        for(int i = 0; i < 5; i++){
            z = 0;
            for(int j = 0; j < 5; j++){
                if(nums[j] < nums[i]){
                    z++;
                }
            }
            Debug.Log(z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}