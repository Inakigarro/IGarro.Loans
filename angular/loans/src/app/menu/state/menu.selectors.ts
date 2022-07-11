import { createFeatureSelector, createSelector } from "@ngrx/store";
import { MenuState, MENU_FEATURE_KEY } from "./menu.reducer";

export const getMenuState = createFeatureSelector<MenuState>(
    MENU_FEATURE_KEY
);

export const selectLoaded = createSelector(
    getMenuState,
    (state) => state.loaded
);

export const selectExpanded = createSelector(
    getMenuState,
    (state) => state.expanded
);