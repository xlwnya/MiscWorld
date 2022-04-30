using UdonSharp;
using UnityEngine;

namespace Xlwnya.MiscWorld.Camera.USharp
{
    public class CameraMotionVectorsActivator : UdonSharpBehaviour
    {
        void Start()
        {
            UnityEngine.Camera target = GetComponent<UnityEngine.Camera>();
            if (target != null)
            {
                target.depthTextureMode = DepthTextureMode.MotionVectors;
                target.enabled = true;
            }
        }
    }
}
