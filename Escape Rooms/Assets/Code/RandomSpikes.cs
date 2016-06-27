using UnityEngine;
using System.Collections;

public class RandomSpikes : MonoBehaviour {

    public GameObject SpikePrefab;
    public int numberSpikes;

	// Use this for initialization
	void Start () {
	   for(int i = 0; i < numberSpikes; ++i)
       {
            Vector2 xypos = Random.insideUnitCircle * 3.5f;
            Vector3 pos = new Vector3(xypos.x, -0.25f,xypos.y);
            Instantiate(SpikePrefab, pos, Quaternion.identity);
       }
	}
}
