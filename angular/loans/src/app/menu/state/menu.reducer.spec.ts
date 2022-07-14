import { Action } from "@ngrx/store";
import * as MenuReducer from './menu.reducer';
import * as MenuActions from './menu.actions';

describe('Menu Reducer', () => {
    it('Should have initial state.', () => {
        // Arrange
        const action = {type: 'sarasa'} as Action;

        // Act.
        const reducerResult = MenuReducer.reducer(MenuReducer.initialState, action);

        // Assert.
        expect(reducerResult).toEqual(MenuReducer.initialState);
    });
    it('Should initialize menu reducer', () => {
        // Arrange.
        const action = MenuActions.initProfileMenu();
        const mockReducer : MenuReducer.MenuState = {
            loaded: true,
            expanded: false
        }

        // Act.
        const reducerResult = MenuReducer.reducer(MenuReducer.initialState, action);

        // Assert.
        expect(reducerResult).toEqual(mockReducer);
        expect(reducerResult.loaded).toBeTruthy();
    })
})