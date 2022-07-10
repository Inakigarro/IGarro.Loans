import { Action, createReducer, on } from "@ngrx/store";
import * as ShellActions from './shell.actions';

export const SHELL_FEATURE_KEY = "shell";

export interface ShellState {
    loaded: boolean;
}

export interface ShellPartialState {
    readonly [SHELL_FEATURE_KEY] : ShellState
}

export const initialState : ShellState = {
    loaded: false
}

export const shellReducer = createReducer(
    initialState,
    on(ShellActions.initShell, state => ({
        ...state,
        loaded: true
    })),
)

export function reducer(state: ShellState | undefined, action: Action){
    return shellReducer(state, action);
}
