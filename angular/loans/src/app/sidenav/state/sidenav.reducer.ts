import { Statement } from "@angular/compiler";
import { Action, createReducer, on } from "@ngrx/store";
import * as SidenavActions from './sidenav.actions';

export const SIDENAV_FEATURE_KEY = "sidenav";

export interface SidenavState {
    loaded: boolean;
    sidenavExpanded: boolean;
    profileExpanded: boolean;
}

export interface SidenavPartialState {
    readonly [SIDENAV_FEATURE_KEY]: SidenavState
}

export const initialState : SidenavState = {
    loaded: false,
    sidenavExpanded: false,
    profileExpanded: false
}

export const sidenavReducer = createReducer(
    initialState,
    on(SidenavActions.initSidenav, state => ({
        ...state,
        loaded: true,
        sidenavExpanded: true
    })),
    on(
        SidenavActions.expandSidenav,
        SidenavActions.hideSidenav,
        (state, action) => ({
            ...state,
            sidenavExpanded: action.expanded
        })
    ),
    on(
        SidenavActions.expandProfile,
        SidenavActions.hideProfile,
        (state, action) => ({
            ...state,
            profileExpanded: action.expanded
        })
    ),
    on(SidenavActions.backdropClicked, state => ({
        ...state,
        profileExpanded: false
    }))
);

export function reducer(state: SidenavState | undefined, action: Action){
    return sidenavReducer(state, action);
}