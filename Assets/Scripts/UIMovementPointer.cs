using UnityEngine;
public class UIMovementPointer : GameUIBase, IPointerDownHandler, IDragHandler, IPointerUpHandler, IEventSystemHandler
{
    // Fields
    private TzarGames.TzarHero.TH_PlayerCharacter _playerComponentCharacter;
    private UnityEngine.EventSystems.PointerEventData cachedEventData;
    private bool pointerDown;
    
    // Methods
    public UIMovementPointer()
    {
    
    }
    protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player player)
    {
        if(0 == player.PlayerObject)
        {
                return;
        }
        
        this._playerComponentCharacter = player.PlayerObject.GetComponent<TzarGames.TzarHero.TH_PlayerCharacter>();
    }
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        float val_4;
        if(eventData != null)
        {
                UnityEngine.Vector2 val_1 = eventData.position;
            val_4 = val_1.x;
        }
        else
        {
                UnityEngine.Vector2 val_2 = 0.position;
            val_4 = val_2.x;
        }
        
        UnityEngine.Vector2 val_3 = eventData.position;
        this._playerComponentCharacter.HandleClick(x:  val_4, y:  val_3.y);
        this.pointerDown = true;
        this.cachedEventData = eventData;
    }
    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        float val_4;
        if(eventData != null)
        {
                UnityEngine.Vector2 val_1 = eventData.position;
            val_4 = val_1.x;
        }
        else
        {
                UnityEngine.Vector2 val_2 = 0.position;
            val_4 = val_2.x;
        }
        
        UnityEngine.Vector2 val_3 = eventData.position;
        this._playerComponentCharacter.HandleClick(x:  val_4, y:  val_3.y);
        this.cachedEventData = eventData;
    }
    public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.pointerDown = false;
        this.cachedEventData = 0;
    }
    private void Update()
    {
        if(this.pointerDown == false)
        {
                return;
        }
        
        if(this.cachedEventData == null)
        {
                return;
        }
        
        if(0 == this._playerComponentCharacter)
        {
                return;
        }
        
        UnityEngine.Vector2 val_2 = this.cachedEventData.position;
        UnityEngine.Vector2 val_3 = this.cachedEventData.position;
        this._playerComponentCharacter.HandleClick(x:  val_2.x, y:  val_3.y);
    }

}
