using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement;

public class navMenuSettings : MonoBehaviour
{
  public static navMenuSettings instance
  {
    get;
    private set;
  }

  public SnapTurnProvider snapTurnProvider;
  public ContinuousTurnProvider continuousTurnProvider;

  public TeleportationManager teleportationManager;
  public ContinuousMoveProvider continuousMoveProvider;

  public GameObject PanelSettings;

  public bool isSnapTurn = true;
  public bool isTeleportMove = true;
  public float volume = 1f;

  void Awake()
  {
    if (instance != null && instance != this)
    {
      Destroy(gameObject);
      return;
    }

    instance = this;
    DontDestroyOnLoad(gameObject);
  }

  void Start()
  {
    ApplyTurnSetting();
    ApplyMoveSetting();
    ApplyVolume();
  }

  public void SetVolume(float value)
  {
    volume = value;
    ApplyVolume();
  }

  private void ApplyVolume()
  {
    AudioListener.volume = volume;
  }

  public void SnapTurn()
  {
    isSnapTurn = true;
    ApplyTurnSetting();
  }

  public void SmoothTurn()
  {
    isSnapTurn = false;
    ApplyTurnSetting();
  }

  private void ApplyTurnSetting()
  {
    if (snapTurnProvider != null)
    {
      snapTurnProvider.enabled = isSnapTurn;
    }
    if (continuousTurnProvider != null)
    {
      continuousTurnProvider.enabled = !isSnapTurn;
    }
  }

  private void ApplyMoveSetting()
  {
    if (continuousMoveProvider != null)
    {
      continuousMoveProvider.enabled = !isTeleportMove;
    }
    if (teleportationManager != null)
    {
      teleportationManager.enabled = isTeleportMove;
    }
  }

  public void TeleportMove()
  {
    isTeleportMove = true;
    ApplyMoveSetting();
  }

  public void FreeMove()
  {
    isTeleportMove = false;
    ApplyMoveSetting();
  }



}
