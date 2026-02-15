using Content.Shared.Shuttles.Events;
using Robust.Client.Graphics;
using Robust.Shared.Utility;

namespace Content.Client.Shuttles.Systems;

public sealed partial class ShuttleSystem
{
    [Dependency] private readonly IOverlayManager _overlays = default!;

    public override void Initialize()
    {
        base.Initialize();
        InitializeEmergency();
        SubscribeNetworkEvent<ShuttleDataResponse>(RecieveShuttleData);
        _overlays.AddOverlay(new FtlArrivalOverlay());
    }

    public delegate void ShuttleData(ShuttleDataResponse dataResponse);
    public event ShuttleData? ShuttleDataRecieved;

    public void RequestShuttleData(ResPath ShuttlePath)
    {
        RaiseNetworkEvent(new ShuttleDataRequestEvent()
        {
            ShuttleResPath = ShuttlePath
        });
    }

    private void RecieveShuttleData(ShuttleDataResponse res)
    {
        ShuttleDataRecieved?.Invoke(res);
    }

    public override void Shutdown()
    {
        base.Shutdown();
        _overlays.RemoveOverlay<FtlArrivalOverlay>();
    }
}
