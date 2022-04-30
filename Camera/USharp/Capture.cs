using UdonSharp;
using UnityEngine;

namespace Xlwnya.MiscWorld.Camera.USharp
{
    public class Capture : UdonSharpBehaviour
    {
        public Texture2D targetTexture;
        private UnityEngine.Camera _camera;

        void Start()
        {
            _camera = GetComponent<UnityEngine.Camera>();
        }

        private void OnPostRender()
        {
            targetTexture.ReadPixels(_camera.pixelRect, 0, 0, false);
            targetTexture.Apply(false);
        }
    }
}
