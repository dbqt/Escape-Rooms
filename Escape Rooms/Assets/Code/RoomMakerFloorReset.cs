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
            floor.transform.position = new Vector3(floor.transform.position.x, 0f, floor.transform.position.z);
        }
        base.reset();
    }
}
