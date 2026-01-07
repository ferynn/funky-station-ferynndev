using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._Funkystation.Implants.Components;

[RegisterComponent, NetworkedComponent]

public sealed partial class VIPTrackerCCImplantComponent : Component
{
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public bool AlertCalled = false;

    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public bool IsEmagged = false;
}
