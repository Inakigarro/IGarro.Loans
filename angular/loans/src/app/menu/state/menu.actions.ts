import { createAction, props } from "@ngrx/store";

export const initProfileMenu = createAction(
    '[Profile Menu] - Profile menu initialized'
);

export const profileButtonClicked = createAction(
    '[Profile Button] - Profile button clicked',
    props<{expanded: boolean}>()
);