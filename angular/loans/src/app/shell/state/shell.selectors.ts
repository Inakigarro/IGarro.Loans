import { createFeatureSelector, createSelector } from "@ngrx/store";
import { ShellState, SHELL_FEATURE_KEY } from "./shell.reducer";

export const getShellState = createFeatureSelector<ShellState>(
    SHELL_FEATURE_KEY
);

export const selectLoaded = createSelector(
    getShellState,
    (state) => state.loaded
);

export const selectProfileExpanded = createSelector(
    getShellState,
    (state) => state.profileExpanded
)