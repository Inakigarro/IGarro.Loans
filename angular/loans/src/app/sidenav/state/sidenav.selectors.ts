import { createFeatureSelector, createSelector } from "@ngrx/store";
import { SidenavState, SIDENAV_FEATURE_KEY } from "./sidenav.reducer";

export const getSidenavState = createFeatureSelector<SidenavState>(
    SIDENAV_FEATURE_KEY
);

export const selectLoaded = createSelector(
    getSidenavState,
    (state) => state.loaded
);

export const selectExpanded = createSelector(
    getSidenavState,
    (state) => state.expanded
);