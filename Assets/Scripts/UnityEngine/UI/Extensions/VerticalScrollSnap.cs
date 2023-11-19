using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class VerticalScrollSnap : ScrollSnapBase, IEndDragHandler, IEventSystemHandler
    {
        // Methods
        public VerticalScrollSnap()
        {
        
        }
        private void Start()
        {
            mem[1152921512755739744] = 1;
            CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  0.5f, r:  0f);
            mem[1152921512755739768] = val_1.m_Height;
            mem[1152921512755739772] = val_1.m_Height >> 32;
            mem[1152921512755739812] = ???;
            this.UpdateLayout();
        }
        private void Update()
        {
            float val_18;
            if(true != 0)
            {
                goto label_1;
            }
            
            UnityEngine.Vector2 val_1 = velocity;
            val_18 = val_1.x;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = val_18, y = val_1.y}, rhs:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y})) == false)
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_4 = localPosition;
            if((this.IsRectSettledOnaPage(pos:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) == true)
            {
                    return;
            }
            
            goto label_10;
            label_5:
            label_1:
            UnityEngine.Vector3 val_7 = localPosition;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = V10.16B, y = V11.16B, z = V12.16B}, t:  S15 * UnityEngine.Time.deltaTime);
            val_18 = val_10.x;
            localPosition = new UnityEngine.Vector3() {x = val_18, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_11 = localPosition;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = V10.16B, y = V11.16B, z = V12.16B})) < 0)
            {
                    mem[1152921512755851796] = 0;
                this.EndScreenChange();
            }
            
            UnityEngine.Vector3 val_13 = localPosition;
            this.CurrentPage = this.GetPageforPosition(pos:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            if(31069 != 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_15 = velocity;
            if((double)val_15.y <= 0.01)
            {
                    UnityEngine.Vector2 val_16 = velocity;
                if((double)val_16.y >= 0)
            {
                    return;
            }
            
            }
            
            if((this.IsRectMovingSlowerThanThreshold(startingSpeed:  0f)) == false)
            {
                    return;
            }
            
            label_10:
            this.ScrollToClosestElement();
        }
        private bool IsRectMovingSlowerThanThreshold(float startingSpeed)
        {
            var val_6;
            UnityEngine.Vector2 val_1 = X20.velocity;
            if(val_1.y > startingSpeed)
            {
                    UnityEngine.Vector2 val_2 = X20.velocity;
                if(val_2.y < 0)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
            }
            
            UnityEngine.Vector2 val_3 = X20.velocity;
            if(val_3.y < 0)
            {
                    UnityEngine.Vector2 val_4 = X20.velocity;
                var val_5 = (val_4.y > ((float)-W8)) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        public void DistributePages()
        {
            var val_19;
            float val_20;
            mem[1152921512756108516] = childCount;
            verticalNormalizedPosition = 0f;
            UnityEngine.Rect val_4 = this.gameObject.GetComponent<UnityEngine.RectTransform>().rect;
            float val_6 = (float)(int)val_4.m_XMin * ((val_4.m_YMin == 0f) ? 3f : val_4.m_YMin);
            val_19 = 0;
            mem[1152921512756108524] = val_6;
            goto label_6;
            label_18:
            X21.anchorMin = new UnityEngine.Vector2() {x = V10.16B, y = V11.16B};
            val_19 = 1;
            label_6:
            UnityEngine.Transform val_7 = X21.transform;
            if(val_19 >= val_7.childCount)
            {
                goto label_9;
            }
            
            UnityEngine.RectTransform val_12 = val_7.transform.GetChild(index:  1).gameObject.GetComponent<UnityEngine.RectTransform>();
            float val_19 = 1f;
            val_19 = val_6 * val_19;
            float val_13 = val_19 + 0f;
            CinemachineFreeLook.Orbit val_14 = new CinemachineFreeLook.Orbit(h:  val_19, r:  val_19);
            if(val_12 != null)
            {
                    val_12.sizeDelta = new UnityEngine.Vector2() {x = val_14.m_Height, y = val_14.m_Radius};
                CinemachineFreeLook.Orbit val_15;
                val_20 = val_13;
                val_15 = new CinemachineFreeLook.Orbit(h:  0f, r:  val_20);
            }
            else
            {
                    val_12.sizeDelta = new UnityEngine.Vector2() {x = val_14.m_Height, y = val_14.m_Radius};
                CinemachineFreeLook.Orbit val_16;
                val_20 = val_13;
                val_16 = new CinemachineFreeLook.Orbit(h:  0f, r:  val_20);
            }
            
            val_12.anchoredPosition = new UnityEngine.Vector2() {x = val_16.m_Height, y = val_16.m_Radius};
            if(val_12 == null)
            {
                goto label_16;
            }
            
            val_12.pivot = new UnityEngine.Vector2() {x = val_19, y = V11.16B};
            val_12.anchorMax = new UnityEngine.Vector2() {x = val_19, y = V11.16B};
            goto label_18;
            label_16:
            val_12.pivot = new UnityEngine.Vector2() {x = val_19, y = V11.16B};
            val_12.anchorMax = new UnityEngine.Vector2() {x = val_19, y = V11.16B};
            goto label_18;
            label_9:
            CinemachineFreeLook.Orbit val_18 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
            val_7.GetComponent<UnityEngine.RectTransform>().offsetMax = new UnityEngine.Vector2() {x = val_18.m_Height, y = val_18.m_Radius};
        }
        public void AddChild(UnityEngine.GameObject GO)
        {
            this.AddChild(GO:  GO, WorldPositionStays:  false);
        }
        public void AddChild(UnityEngine.GameObject GO, bool WorldPositionStays)
        {
            verticalNormalizedPosition = 0f;
            WorldPositionStays = WorldPositionStays;
            GO.transform.SetParent(parent:  GO, worldPositionStays:  WorldPositionStays);
            this.InitialiseChildObjectsFromScene();
            this.DistributePages();
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.UpdateVisible();
            }
            
            this.SetScrollContainerPosition();
        }
        public void RemoveChild(int index, out UnityEngine.GameObject ChildRemoved)
        {
            ChildRemoved = 0;
            if(((index >> 30) & 2) != 0)
            {
                    return;
            }
            
            if(childCount < index)
            {
                    return;
            }
            
            verticalNormalizedPosition = 0f;
            UnityEngine.Transform val_4 = transform.GetChild(index:  index);
            if(val_4 != null)
            {
                    val_4.SetParent(parent:  0);
            }
            else
            {
                    0.SetParent(parent:  0);
            }
            
            ChildRemoved = val_4.gameObject;
            this.InitialiseChildObjectsFromScene();
            this.DistributePages();
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.UpdateVisible();
            }
            
            this.CurrentPage = (UnityEngine.Object.__il2cppRuntimeField_cctor_finished - 1)>>0&0xFFFFFFFF;
            this.SetScrollContainerPosition();
        }
        public void RemoveAllChildren(out UnityEngine.GameObject[] ChildrenRemoved)
        {
            UnityEngine.GameObject[] val_9;
            var val_10;
            int val_1 = childCount;
            val_9 = val_1;
            ChildrenRemoved = null;
            val_10 = null;
            int val_2 = val_1 - 1;
            if((val_2 & 2147483648) == 0)
            {
                    do
            {
                val_9 = ChildrenRemoved;
                UnityEngine.GameObject[] val_5 = val_9 + (((long)(int)((val_1 - 1))) << 3);
                mem2[0] = val_1.GetChild(index:  (long)val_2).gameObject;
                UnityEngine.GameObject[] val_6 = ChildrenRemoved + (((long)(int)((val_1 - 1))) << 3);
                mem[(ChildrenRemoved + ((long)(int)((val_1 - 1))) << 3) + 32].transform.SetParent(parent:  0);
                val_10 = (long)val_2 - 1;
            }
            while((val_10 & 2147483648) == 0);
            
            }
            
            ChildrenRemoved.verticalNormalizedPosition = 0f;
            this.CurrentPage = 0;
            this.InitialiseChildObjectsFromScene();
            this.DistributePages();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.UpdateVisible();
        }
        private void SetScrollContainerPosition()
        {
            UnityEngine.Vector3 val_1 = X20.localPosition;
            mem[1152921512756791080] = val_1.y;
            float val_3 = (float)W21;
            val_3 = val_3 / ((float)W22 - 1);
            X20.verticalNormalizedPosition = val_3;
        }
        public void UpdateLayout()
        {
            mem[1152921512756903124] = 0;
            this.DistributePages();
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.UpdateVisible();
            }
            
            this.SetScrollContainerPosition();
        }
        private void OnRectTransformDimensionsChange()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = V9.16B, y = V8.16B}, rhs:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y})) == false)
            {
                    return;
            }
            
            this.UpdateLayout();
        }
        public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_10;
            mem[1152921512757131221] = 0;
            if(vertical == false)
            {
                    return;
            }
            
            if(true == 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_2 = velocity;
            if(val_2.y <= 0f)
            {
                goto label_5;
            }
            
            UnityEngine.Vector2 val_3 = velocity;
            val_10 = (float)val_3.x;
            if(val_3.y > val_10)
            {
                goto label_7;
            }
            
            label_5:
            UnityEngine.Vector2 val_4 = velocity;
            if(val_4.y >= 0)
            {
                goto label_11;
            }
            
            UnityEngine.Vector2 val_5 = velocity;
            val_10 = -1f;
            if(val_5.y >= 0)
            {
                goto label_11;
            }
            
            label_7:
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            velocity = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            UnityEngine.Vector3 val_8 = localPosition;
            if((val_7.x - val_8.y) <= 0f)
            {
                goto label_18;
            }
            
            this.NextScreen();
            return;
            label_11:
            this.ScrollToClosestElement();
            return;
            label_18:
            this.PreviousScreen();
        }
    
    }

}
