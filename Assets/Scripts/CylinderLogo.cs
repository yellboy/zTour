using HoloToolkit.Unity.SpatialMapping;
using UnityEngine;

namespace Assets.Scripts
{
    public class CylinderLogo : TapToPlace
    {
	
        // Update is called once per frame
        protected override void Update ()
        {
            base.Update();

            if (IsBeingPlaced)
            {
                gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x + 90,
                    gameObject.transform.rotation.y, gameObject.transform.rotation.z, gameObject.transform.rotation.w);
            }
        }
    }
}
