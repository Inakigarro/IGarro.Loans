import { Action } from "@ngrx/store";
import * as ShellReducer from './shell.reducer';
import * as ShellActions from './shell.actions';

describe('Shell Reducer', () => {
    it('Should return initialState', () => {
        // Arrange.
        const action = {type: 'sarasa'} as Action;
        
        // Act.
        const reducerResult = ShellReducer.reducer(ShellReducer.initialState, action);

        // Assert.
        expect(reducerResult).toEqual(ShellReducer.initialState);
    });

    it('Should set loaded true', () => {
        // Arrange.
        const action = ShellActions.initShell();

        const mockReducer : ShellReducer.ShellState = {
            loaded: true
        }

        // Act.
        const reducerResult = ShellReducer.reducer(ShellReducer.initialState, action);

        // Assert.
        expect(reducerResult).toEqual(mockReducer);
    })
})