import { Action } from '@ngrx/store';
import * as HeaderReducer from './header.reducer';

describe('Header Reducer', () => {
    it('Should have initial state.', () => {
        // Arrange
        const action = {type: 'sarasa'} as Action;

        // Act.
        const reducerResult = HeaderReducer.reducer(HeaderReducer.initalState, action);

        expect(reducerResult).toEqual(HeaderReducer.initalState);
    })
})