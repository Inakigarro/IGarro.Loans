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
            sidenavExpanded: true
        };

        // Act.
        const reducerResult = SidenavReducer.reducer(SidenavReducer.initialState, action);

        // Assert.
        expect(reducerResult).toEqual(mockReducer);
    });
    it('Should hide sidenav', () => {
        // Arrange.
        const action = SidenavActions.hideSidenav({
            expanded: false
        });

        const mockReducer : SidenavReducer.SidenavState = {
            loaded: true,
            sidenavExpanded: true
        };

        const expectedReducer : SidenavReducer.SidenavState = {
            loaded: true,
            sidenavExpanded: false
        };

        // Act.
        const reducerResult = SidenavReducer.reducer(mockReducer, action);

        // Assert.
        expect(reducerResult).toEqual(expectedReducer);
    });
    it('Should expand sidenav', () => {
        // Arrange.
        const action = SidenavActions.expandSidenav({
            expanded: true
        });

        const mockReducer : SidenavReducer.SidenavState = {
            loaded: true,
            sidenavExpanded: false
        };

        const expectedReducer : SidenavReducer.SidenavState = {
            loaded: true,
            sidenavExpanded: true
        };

        // Act.
        const reducerResult = SidenavReducer.reducer(mockReducer, action);

        // Assert.
        expect(reducerResult).toEqual(expectedReducer);
    })
})