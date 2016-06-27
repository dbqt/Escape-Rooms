using UnityEngine;
using System.Collections;
using System.Linq;

public class RoomMakerFloorReset : roomMaker {

    public GameObject[] FallingFloors;

    public override void reset()
    {
        foreach(GameObject floor in FallingFloors)
        {
            floor.GetComponent<FallingFloorLogic>().ResetFloor();
            if (!floor.CompareTag("Ledge"))
                floor.transform.position = new Vector3(floor.transform.position.x, 0.0f, floor.transform.position.z);
            else
                floor.transform.position = new Vector3(floor.transform.position.x, 1.0f, floor.transform.position.z);
        }
        base.reset();
    }
}
