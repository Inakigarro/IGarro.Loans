import { createAction } from "@ngrx/store";

export const initHeader = createAction(
    '[Header] - Header initialized'
);

export const menuButtonClicked = createAction(
    '[Header Menu Button] - Menu button clickead'
)