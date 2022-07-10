import { Action, createReducer, on } from "@ngrx/store";
import * as SidenavActions from './sidenav.actions';

export const SIDENAV_FEATURE_KEY = "sidenav";

export interface SidenavState {
    loaded: boolean;
    expanded: boolean;
}

export interface SidenavPartialState {
    readonly [SIDENAV_FEATURE_KEY]: SidenavState
}

export const initialState : SidenavState = {
    loaded: false,
    expanded: false
}

export const sidenavReducer = createReducer(
    initialState,
    on(SidenavActions.initSidenav, state => ({
        ...state,
        loaded: true,
        expanded: true
    })),
    on(
        SidenavActions.expandSidenav,
        SidenavActions.hideSidenav,
        (state, action) => ({
            ...state,
            expanded: action.expanded
        })
    )
);

export function reducer(state: SidenavState | undefined, action: Action){
    return sidenavReducer(state, action);
}