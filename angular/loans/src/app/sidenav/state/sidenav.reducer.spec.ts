import { Action } from "@ngrx/store";
import * as SidenavReducer from './sidenav.reducer';
import * as SidenavActions from './sidenav.actions';
import { state } from "@angular/animations";

describe('Sidenav Reducer', () => {
    it('Should return initialState', () => {
        // Arrange.
        const action = {type: 'sarasa'} as Action;
        
        // Act.
        const reducerResult = SidenavReducer.reducer(SidenavReducer.initialState, action);

        // Assert.
        expect(reducerResult).toEqual(SidenavReducer.initialState);
    });
    it('Should initialize sidenav', () => {
        // Arrange.
        const action = SidenavActions.initSidenav();

        const mockReducer : SidenavReducer.SidenavState = {
            loaded: true,
            expanded: true
        };

        // Act.
        const reducerResult = SidenavReducer.reducer(SidenavReducer.initialState, action);

        // Assert.
        expect(reducerResult).toEqual(mockReducer);
    });
    it('Should hide sidenav', () => {
        // Arrange.
        const action = SidenavActions.hideSidenav();

        const mockReducer : SidenavReducer.SidenavState = {
            loaded: true,
            expanded: true
        };

        const expectedReducer : SidenavReducer.SidenavState = {
            loaded: true,
            expanded: false
        };

        // Act.
        const reducerResult = SidenavReducer.reducer(mockReducer, action);

        // Assert.
        expect(reducerResult).toEqual(expectedReducer);
    });
    it('Should expand sidenav', () => {
        // Arrange.
        const action = SidenavActions.expandSidenav();

        const mockReducer : SidenavReducer.SidenavState = {
            loaded: true,
            expanded: false
        };

        const expectedReducer : SidenavReducer.SidenavState = {
            loaded: true,
            expanded: true
        };

        // Act.
        const reducerResult = SidenavReducer.reducer(mockReducer, action);

        // Assert.
        expect(reducerResult).toEqual(expectedReducer);
    })
})