import { createReducer, Action, on } from "@ngrx/store";
import * as HeaderActions from '../state/header.actions'; 

export const HEADER_FEATURE_KEY = "header";

export interface HeaderState {
    loaded: boolean
}

export const initialState : HeaderState = {
    loaded: false
}

export const headerReducer = createReducer(
    initialState,
    on(HeaderActions.initHeader, state => ({
        ...state,
        loaded: true
    }))
);

export function reducer(state: HeaderState | undefined, action: Action){
    return headerReducer(state, action);
}