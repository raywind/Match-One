//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class EventSystems : Feature {

    public EventSystems(Contexts contexts) {
        Add(new AssetEventSystem(contexts)); // priority: 0
        Add(new BurstModeRemovedEventSystem(contexts)); // priority: 0
        Add(new BurstModeEventSystem(contexts)); // priority: 0
        Add(new DestroyedEventSystem(contexts)); // priority: 0
        Add(new PositionEventSystem(contexts)); // priority: 0
        Add(new ScoreEventSystem(contexts)); // priority: 0
    }
}
