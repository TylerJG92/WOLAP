* Fixed the flow of the quests within Ghostwood
    * Added a flag `gwloggingquestprogression` as another flag gate to make sure that each step of the ghostwood logging permit is done in the right order instead of items accidentally forcing flag progression elsewhere when it shouldnt.
    * player can be locked out of parts of the ghost whiskey quest, While this is intended in vanilla, I want to remove the problem incase the right conditions exist
        * Added a new dialogue that basically allows the player to borrow a ghost pencil at the cost of filling out paperwork to borrow it and additional paperwork for each item it will be used for
            * Added a flag gate that if the mayor still has the players ghost pencil and they had chosen to borrow the pencil for the whiskey quest that when they go back to the borrowee they will state that they cannot allow you to take the pencil from their store as it is hard to come by.
