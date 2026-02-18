
using Robust.Shared.Serialization;
using Robust.Shared.Utility;

namespace Content.Shared.Shuttles.Events
{
    [Serializable, NetSerializable]

    public sealed class ShuttleDataResponse : EntityEventArgs
    {
        public ResPath ShuttleResPath { get; set; }
        public NetEntity? Map;
    }
}
