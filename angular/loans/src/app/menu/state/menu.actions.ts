import { createAction, props } from "@ngrx/store";

export const initProfileMenu = createAction(
    '[Profile Menu] - Profile menu initialized'
);

export const profilePictureButton = createAction(
    '[Profile Picture Button] - Profile picture button clicked'
)

export const profileButtonClicked = createAction(
    '[Profile Button] - Profile button clicked'
);