using UnityEngine;

namespace SA.Common.Extensions
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class SA_TextureExtensions
    {
        // Methods
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.Sprite ToSprite(UnityEngine.Texture texture)
        {
            CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  0.5f, r:  0.5f);
            if(X1 == 0)
            {
                    return (UnityEngine.Sprite)UnityEngine.Sprite.Create(texture:  0, rect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, pivot:  new UnityEngine.Vector2() {x = val_1.m_Height, y = val_1.m_Radius});
            }
            
            var val_2 = (X1 == null) ? (X1) : 0;
            return (UnityEngine.Sprite)UnityEngine.Sprite.Create(texture:  0, rect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, pivot:  new UnityEngine.Vector2() {x = val_1.m_Height, y = val_1.m_Radius});
        }
    
    }

}
