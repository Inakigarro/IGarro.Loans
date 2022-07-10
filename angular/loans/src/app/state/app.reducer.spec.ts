import { Action } from '@ngrx/store';
import * as AppReducer from './app.reducer';
import * as AppActions from './app.actions';

describe('App Reducer', () => {
    it('Should return initialState', () => {
        // Arrange.
        const action = {type: 'sarasa'} as Action;
        
        // Act.
        const reducerResult = AppReducer.reducer(AppReducer.initialState, action);

        // Assert.
        expect(reducerResult).toEqual(AppReducer.initialState);
    });
    it('Should set loaded true', () => {
        // Arrange.
        const action = AppActions.initApp;
        const mockReducer : AppReducer.AppState = {
            loaded: true
        }

        // Act.
        const reducerResult = AppReducer.reducer(AppReducer.initialState, action);

        // Assert.
        expect(reducerResult).toEqual(mockReducer);
    })
})