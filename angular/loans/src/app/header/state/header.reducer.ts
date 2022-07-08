import { createReducer, Action, on } from "@ngrx/store";
import * as HeaderActions from '../state/header.actions'; 

export const HEADER_FEATURE_KEY = "header";

export interface HeaderState {
    loaded: boolean
}

export const initalState : HeaderState = {
    loaded: false
}

export const headerReducer = createReducer(
    initalState,
    on(HeaderActions.testAction, state => ({
        ...state,
        loaded: true
    }))
);

export function reducer(state: HeaderState | undefined, action: Action){
    return headerReducer(state, action);
}