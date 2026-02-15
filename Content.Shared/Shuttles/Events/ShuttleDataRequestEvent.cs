
using Robust.Shared.Serialization;
using Robust.Shared.Utility;

namespace Content.Shared.Shuttles.Events
{
    [Serializable, NetSerializable]
    public sealed class ShuttleDataRequestEvent : EntityEventArgs
    {
        public ResPath ShuttleResPath { get; set; }
    }
}
