import { Action, createReducer, on } from "@ngrx/store";
import * as AppActions from './app.actions';

export const APP_FEATURE_KEY = "app";

export interface AppState {
    loaded: boolean;
}

export interface AppPartialState {
    readonly [APP_FEATURE_KEY] : AppState
}

export const initialState : AppState = {
    loaded: false
}

export const appReducer = createReducer(
    initialState,
    on(AppActions.initApp, state => ({
        ...state,
        loaded: true
    }))
)

export function reducer(state: AppState | undefined, action: Action){
    return appReducer(state, action);
}