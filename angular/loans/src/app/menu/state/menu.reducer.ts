import { Action, createReducer, on } from "@ngrx/store";
import * as MenuActions from './menu.actions';

export const MENU_FEATURE_KEY = 'menu';

export interface MenuState {
    loaded: boolean,
    expanded: boolean
};

export interface MenuPartialState {
    readonly [MENU_FEATURE_KEY] : MenuState
};

export const initialState : MenuState = {
    loaded: false,
    expanded: false
};

export const menuReducer = createReducer(
    initialState,
    on(MenuActions.initProfileMenu, state => ({
        ...state,
        loaded: true
    })),
    on(MenuActions.profilePictureButton, (state, action) => ({
        ...state,
        expanded: !state.expanded
    }))
);

export function reducer(state: MenuState | undefined, action: Action){
    return menuReducer(state, action);
}