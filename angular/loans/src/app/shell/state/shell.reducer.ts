import { Action, createReducer, on } from "@ngrx/store";
import * as ShellActions from './shell.actions';

export const SHELL_FEATURE_KEY = "shell";

export interface ShellState {
    loaded: boolean;
    sidenavExpanded: boolean;
    profileExpanded: boolean;
}

export interface ShellPartialState {
    readonly [SHELL_FEATURE_KEY] : ShellState
}

export const initialState : ShellState = {
    loaded: false,
    sidenavExpanded: false,
    profileExpanded: false
}

export const shellReducer = createReducer(
    initialState,
    on(ShellActions.initShell, state => ({
        ...state,
        loaded: true
    })),
    on(ShellActions.profileButtonClicked, state =>({
        ...state,
        profileExpanded: !state.profileExpanded
    })),
    on(
        ShellActions.expandSidenav,
        ShellActions.hideSidenav,
        (state, action) => ({
            ...state,
            sidenavExpanded: action.expanded
        })
    ),
    on(ShellActions.backdropClicked, state => ({
        ...state,
        profileExpanded: false
    }))
)

export function reducer(state: ShellState | undefined, action: Action){
    return shellReducer(state, action);
}
