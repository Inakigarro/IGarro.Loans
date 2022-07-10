import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { map } from "rxjs";
import { initShell } from "src/app/shell/state/shell.actions";
import { initHeader, menuButtonClicked } from "./header.actions";

@Injectable()
export class HeaderEffects {
    public initHeader$ = createEffect(() =>
        this.actions$.pipe(
            ofType(initShell),
            map(() => initHeader())
        )
    );

    constructor(private readonly actions$: Actions){}
}