using Content.Server.OuterRim.Generator;
using Content.Server.Power.Components;

namespace Content.Server.Power.EntitySystems;

public static class StaticPowerSystem
{
    // Using this makes the call shorter.
    // ReSharper disable once UnusedParameter.Global
    public static bool IsPowered(this EntitySystem system, EntityUid uid, IEntityManager entManager, ApcPowerReceiverComponent? receiver = null)
    {
        return (entManager.TryGetComponent<ApcPowerReceiverComponent>(uid, out receiver) && receiver.Powered)
            || (entManager.TryGetComponent<GasPowerProviderComponent>(uid, out var gasPower) && gasPower.Powered);
    }
}
