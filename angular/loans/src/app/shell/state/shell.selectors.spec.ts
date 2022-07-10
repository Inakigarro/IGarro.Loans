import * as ShellReducer from "./shell.reducer"
import * as ShellSelectors from './shell.selectors';

describe('Shell Selectors', () => {
    it('Should return loaded', () => {
        // Arrange.
        const state: ShellReducer.ShellState = {
            ...ShellReducer.initialState,
            loaded: false
        };

        const shellState: ShellReducer.ShellPartialState = {
            [ShellReducer.SHELL_FEATURE_KEY]: state
        };

        // Act.
        const shellSelector = ShellSelectors.selectLoaded;
        const expected = shellSelector(shellState);

        // Assert.
        expect(expected).toBeFalsy();
    })
})