import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { map } from "rxjs";
import { initApp } from "src/app/state/app.actions";
import { initShell } from "./shell.actions";

@Injectable()
export class ShellEffects {
    public initShell$ = createEffect(() => 
        this.actions$.pipe(
            ofType(initApp),
            map(() => initShell())
        ));
    constructor(private readonly actions$: Actions){}
}