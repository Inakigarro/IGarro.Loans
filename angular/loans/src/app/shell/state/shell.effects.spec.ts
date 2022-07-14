import { TestBed } from "@angular/core/testing";
import { Action } from "@ngrx/store";
import { provideMockStore } from "@ngrx/store/testing";
import { provideMockActions } from "@ngrx/effects/testing";
import { Observable } from "rxjs";
import { ShellService } from "../service/shell.service";
import { ShellEffects } from "./shell.effects";
import { hot } from 'jasmine-marbles'
import { initApp } from '../../state/app.actions';
import { initShell } from "./shell.actions";

function configureTestingModule(
    action: Observable<Action>
){
    TestBed.configureTestingModule({
        providers:[
            ShellService,
            ShellEffects,
            provideMockStore(),
            provideMockActions(() => action),
        ]
    });
}

describe('Shell Effects', () => {
    it('On initApp, should dispatch initShell', () => {
        // Arrange.
        const actions = hot('-a-|', {
            a: initApp()
        })

        configureTestingModule(actions);

        const expected = hot('-a-|', {
            a: initShell()
        });

        // Act.
        const effects = TestBed.inject(ShellEffects);

        // Assert.
        expect(effects.initShell$).toBeObservable(expected);
    })
})