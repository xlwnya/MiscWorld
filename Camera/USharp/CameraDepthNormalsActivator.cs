using UdonSharp;
using UnityEngine;

namespace Xlwnya.MiscWorld.Camera.USharp
{
    public class CameraDepthNormalsActivator : UdonSharpBehaviour
    {
        void Start()
        {
            UnityEngine.Camera target = GetComponent<UnityEngine.Camera>();
            if (target != null)
            {
                target.depthTextureMode = DepthTextureMode.DepthNormals;
                target.enabled = true;
            }
        }
    }
}
