﻿public sealed class GameSystems : Feature {

    public GameSystems(Contexts contexts) {

        // Input
        Add(new InputSystem(contexts));

        // Update
        Add(new GameBoardSystems(contexts));
        Add(new ScoreSystem(contexts));

        // Events
        Add(new EventSystems(contexts));

        // Cleanup
        Add(new DestroyEntitySystem(contexts));
    }
}
