using UdonSharp;
using UnityEngine;

namespace Xlwnya.MiscWorld.Camera.USharp
{
    public class CameraDepthActivator : UdonSharpBehaviour
    {
        void Start()
        {
            UnityEngine.Camera target = GetComponent<UnityEngine.Camera>();
            if (target != null)
            {
                target.depthTextureMode = DepthTextureMode.Depth;
                target.enabled = true;
            }
        }
    }
}
