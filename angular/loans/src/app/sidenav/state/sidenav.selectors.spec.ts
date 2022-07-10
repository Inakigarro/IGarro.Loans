import * as SidenavReducer from "./sidenav.reducer"
import * as SidenavSelectors from './sidenav.selectors';

describe('Sidenav Selectors', () => {
    it('Should return loaded', () => {
        // Arrange.
        const state: SidenavReducer.SidenavState = {
            ...SidenavReducer.initialState,
            loaded: true
        };

        const sidenavState : SidenavReducer.SidenavPartialState = {
            [SidenavReducer.SIDENAV_FEATURE_KEY]: state
        };

        // Act.
        const sidenavSelector = SidenavSelectors.selectLoaded;
        const expected = sidenavSelector(sidenavState);

        // Assert.
        expect(expected).toBeTruthy();
    });
    it('Should return expanded', () => {
        // Arrange.
        const state: SidenavReducer.SidenavState = {
            ...SidenavReducer.initialState,
            expanded: true
        };

        const sidenavState : SidenavReducer.SidenavPartialState = {
            [SidenavReducer.SIDENAV_FEATURE_KEY]: state
        };

        // Act.
        const sidenavSelector = SidenavSelectors.selectExpanded;
        const expected = sidenavSelector(sidenavState);

        // Assert.
        expect(expected).toBeTruthy();
    })
})