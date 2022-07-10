import { TestBed } from "@angular/core/testing";
import { provideMockActions } from "@ngrx/effects/testing";
import { Action } from "@ngrx/store";
import { provideMockStore } from "@ngrx/store/testing";
import { Observable } from "rxjs";
import { HeaderEffects } from "./header.effects";
import { hot } from 'jasmine-marbles';
import { initShell } from "src/app/shell/state/shell.actions";
import { initHeader } from "./header.actions";

function configureTestingModule(
    actions: Observable<Action>
){
    TestBed.configureTestingModule({
        providers:[
            HeaderEffects,
            provideMockStore(),
            provideMockActions(() => actions)
        ]
    })
}

describe('Header Effects', () => {
    it('initShell should dispatch initHeader', () => {
        // Arrange.
        const action = hot('-a-|', {
            a: initShell()
        });
        const expected = hot('-a-|', {
            a: initHeader()
        });

        configureTestingModule(action);

        // Act.
        const effects = TestBed.inject(HeaderEffects);

        // Assert.
        expect(effects.initHeader$).toBeObservable(expected);
    })
})