using UnityEngine;

namespace SA.Common.Extensions
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class SA_TweenExtensions
    {
        // Methods
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static void MoveTo(UnityEngine.GameObject go, UnityEngine.Vector3 position, float time, SA.Common.Animation.EaseType easeType = 21, System.Action OnCompleteAction)
        {
            SA.Common.Animation.ValuesTween val_1 = easeType.AddComponent<SA.Common.Animation.ValuesTween>();
            val_1.DestoryGameObjectOnComplete = false;
            UnityEngine.Vector3 val_3 = easeType.transform.position;
            if(val_1 != null)
            {
                    val_1.VectorTo(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, time:  time, easeType:  OnCompleteAction);
            }
            else
            {
                    val_1.VectorTo(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, time:  time, easeType:  OnCompleteAction);
            }
            
            val_1.add_OnComplete(value:  X3);
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static void ScaleTo(UnityEngine.GameObject go, UnityEngine.Vector3 scale, float time, SA.Common.Animation.EaseType easeType = 21, System.Action OnCompleteAction)
        {
            SA.Common.Animation.ValuesTween val_1 = easeType.AddComponent<SA.Common.Animation.ValuesTween>();
            val_1.DestoryGameObjectOnComplete = false;
            UnityEngine.Vector3 val_3 = easeType.transform.localScale;
            if(val_1 != null)
            {
                    val_1.ScaleTo(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = scale.x, y = scale.y, z = scale.z}, time:  time, easeType:  OnCompleteAction);
            }
            else
            {
                    val_1.ScaleTo(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = scale.x, y = scale.y, z = scale.z}, time:  time, easeType:  OnCompleteAction);
            }
            
            val_1.add_OnComplete(value:  X3);
        }
    
    }

}
