using Robust.Shared.Prototypes;

namespace Content.Shared._Coyote;

/// <summary>
/// This is a prototype for...
/// </summary>
[Prototype("flarpiSettings")]
public sealed partial class FlarpiSettingsPrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; } = default!;

    /// <summary>
    /// How many points to give one Flarpi.
    /// </summary>
    [DataField("pointsPerFlarpi")]
    public decimal PointsPerFlarpi { get; set; } = 1000m;

    // Now the complicated part: we want to try and give X flarpies per 1 hours worth of RPI
    // Every second, FLARPI generates enough points to give one second's worth of RPI, but!
    // this scales with the number of freelancers are around you and online

    /// <summary>
    /// How many flarpies to give per 1 hour of RPI generation, alone.
    /// </summary>
    [DataField("flarpiesPerHourAlone")]
    public decimal FlarpiesPerHourAlone { get; set; } = 4m;

    /// <summary>
    /// How many flarpies to give per 1 hour of RPI generation, with one person nearby.
    /// </summary>
    [DataField("flarpiesPerHourOneNearby")]
    public decimal FlarpiesPerHourOneNearby { get; set; } = 8m;

    /// <summary>
    /// How many flarpies to give per 1 hour of RPI generation, with two people nearby.
    /// </summary>
    [DataField("flarpiesPerHourTwoNearby")]
    public decimal FlarpiesPerHourTwoNearby { get; set; } = 16m;

    /// <summary>
    /// How many flarpies to give per 1 hour of RPI generation, with three or more people nearby.
    /// </summary>
    [DataField("flarpiesPerHourThreeOrMoreNearby")]
    public decimal FlarpiesPerHourThreeOrMoreNearby { get; set; } = 32m;

    /// <summary>
    /// The radius to check for nearby freelancers.
    /// </summary>
    [DataField("nearbyRadius")]
    public float NearbyRadius { get; set; } = 25f;
}
